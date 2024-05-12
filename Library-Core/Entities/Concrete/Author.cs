using Library_Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.Entities.Concrete
{
    public class Author : BaseEntity
    {
        public Author()
        {
            Publishers = new List<AuthorPublisher>();
        }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<AuthorPublisher> Publishers { get; set; }
    }
}
