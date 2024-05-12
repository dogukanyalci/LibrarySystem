using Library_Core.Entities.Abstract;
using Library_Core.Entities.UserEntities.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.Entities.UserEntities.Concrete
{
    public class AppUser : IdentityUser, IBaseUser
    {
        private DateTime _createdDate = DateTime.Now;
        private Status _status = Status.Active;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get => _status; set => _status = value; }
    }
}
