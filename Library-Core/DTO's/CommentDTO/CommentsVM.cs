using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.DTO_s.CommentDTO
{
    public class CommentsVM
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string UserComment { get; set; }
        public string UserName { get; set; }
    }
}
