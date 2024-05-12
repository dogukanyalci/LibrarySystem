using Library_Core.Entities.Abstract;
using Library_Core.Entities.UserEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.Entities.Concrete
{
    public class Comment : BaseEntity
    {
        public string Username { get; set; }
        public string UserComment { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
