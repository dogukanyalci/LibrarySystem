using Library_Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.Entities.Concrete
{
    public class Publisher : BaseEntity
    {
        public Publisher()
        {
            Authors = new List<AuthorPublisher>();
        }
        public string Name { get; set; }
        public List<AuthorPublisher> Authors { get; set; }
    }
}
