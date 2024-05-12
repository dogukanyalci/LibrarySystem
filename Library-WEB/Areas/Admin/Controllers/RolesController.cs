using Library_Core.DTO_s.RoleDTO;
using Library_Core.Entities.UserEntities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library_WEB.Areas.Admin.Controllers
{
    public class RolesController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [Area("Admin")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        [Area("Admin")]
        [Authorize(Roles = "admin")]
        public IActionResult CreateRole() => View();

        [Area("Admin")]
        [Authorize(Roles = "admin")]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRole(CreateRoleDTO model)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await _roleManager.CreateAsync
                    (new IdentityRole(model.RoleName));

                if (result.Succeeded)
                {
                    TempData["Success"] = "Role added successfully";
                    return RedirectToAction("Index");
                }

                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                        TempData["error"] = error.Description;
                    }
                    return View(model);
                }
            }
            TempData["Error"] = "Please follow the rules below!";
            return View(model);
        }

        [Area("Admin")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role != null)
            {
                var model = new UpdateRoleDTO { Id = role.Id, RoleName = role.Name };
                return View(model);
            }
            TempData["Error"] = "Role not found!";
            return RedirectToAction("Index");
        }

        [Area("Admin")]
        [Authorize(Roles = "admin")]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateRole(UpdateRoleDTO model)
        {
            if (ModelState.IsValid)
            {
                var role = await _roleManager.FindByIdAsync(model.Id);
                if (role != null)
                {
                    role.Name = model.RoleName;
                    var result = await _roleManager.UpdateAsync(role);
                    if (result.Succeeded)
                    {
                        TempData["Success"] = "Role updated!";
                        return RedirectToAction("Index");
                    }
                    TempData["Error"] = "Failed to update role!";
                    return View(model);
                }
                TempData["Error"] = "Role not found!";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Please follow the rules below!";
            return View(model);
        }
        [Area("Admin")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> AssignedUser(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role != null)
            {
                List<AppUser> hasRole = new List<AppUser>();
                List<AppUser> hasNotRole = new List<AppUser>();

                var users = await _userManager.Users.ToListAsync();

                foreach (var user in users)
                {
                    if (await _userManager.IsInRoleAsync(user, role.Name))
                    {
                        hasRole.Add(user);
                    }
                    else
                    {
                        hasNotRole.Add(user);
                    }
                }

                var model = new AssignedRoleDTO
                {
                    Role = role,
                    HasRole = hasRole,
                    HasNotRole = hasNotRole,
                    RoleName = role.Name
                };

                return View(model);
            }
            TempData["Error"] = "Role not found!";
            return RedirectToAction("Index");
        }

        [Area("Admin")]
        [Authorize(Roles = "admin")]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignedUser(AssignedRoleDTO model)
        {
            IdentityResult result = new IdentityResult();

            foreach (var userId in model.AddIds ?? new string[] { })
            {
                var user = await _userManager.FindByIdAsync(userId);
                result = await _userManager.AddToRoleAsync(user, model.RoleName);
            }

            foreach (var userId in model.DeleteIds ?? new string[] { })
            {
                var user = await _userManager.FindByIdAsync(userId);
                result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
            }

            if (result.Succeeded)
            {
                TempData["Success"] = "The casting was done successfully!";
                return RedirectToAction("Index");
            }

            TempData["Error"] = "Failure to role";
            return View(model);
        }

        [Area("Admin")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role != null)
            {
                var hasRole = new List<AppUser>();
                var users = await _userManager.Users.ToListAsync();

                foreach (var user in users)
                {
                    if (await _userManager.IsInRoleAsync(user, role.Name))
                    {
                        hasRole.Add(user);
                    }
                }

                if (hasRole.Count() == 0)
                {
                    var result = await _roleManager.DeleteAsync(role);
                    if (result.Succeeded)
                    {
                        TempData["Success"] = "Role deleted!";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Error"] = "Role not deleted!";
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    TempData["Error"] = "There are users in this role. You cannot delete them! If you want to delete, first remove users from this role!";
                    return RedirectToAction("AssignedUser", new { id = role.Id });
                }
            }
            TempData["Error"] = "Role not found!";
            return RedirectToAction("Index");

        }
    }
}
