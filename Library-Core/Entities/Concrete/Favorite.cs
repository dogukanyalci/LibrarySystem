using Library_Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.Entities.Concrete
{
    public class Favorite : BaseEntity
    {
        public bool IsFavorite { get; set; }
        
        public int BookId { get; set; }
        public Book Book { get; set; }

        public string AppUserID { get; set; }
        public User User { get; set; }
    }
}
