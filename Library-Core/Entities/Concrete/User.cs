using Library_Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.Entities.Concrete
{
    public class User : BaseEntity
    {
        public User()
        {
            Comments = new List<Comment>();
            Favorites = new List<Favorite>();
        }
        public string AppUserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        
        public List<Comment> Comments { get; set; }
        public List<Favorite> Favorites { get; set; }
    }
}
