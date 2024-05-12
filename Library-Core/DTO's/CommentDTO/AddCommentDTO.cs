using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.DTO_s.CommentDTO
{
	public class AddCommentDTO
	{
		public string Username { get; set; }
		public string UserComment { get; set; }
		public int BookId { get; set; }
		public int UserId { get; set; }
	}
}
