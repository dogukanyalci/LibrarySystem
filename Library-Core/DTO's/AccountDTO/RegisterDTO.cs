using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.DTO_s.AccountDTO
{
    public class RegisterDTO
    {
        [Display(Name = "Ad")]
        public string? FirstName { get; set; }

        [Display(Name = "Soyad")]
        public string? LastName { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string? Username { get; set; }

        [Display(Name = "E-Mail")]
        public string? Email { get; set; }

        [Display(Name = "Parola")]
        public string? Password { get; set; }

        [Display(Name = "Rol")]
        public string? RoleId { get; set; }

        public List<IdentityRole>? Roles { get; set; }
    }
}
