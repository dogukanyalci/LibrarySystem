using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.DTO_s.AuthorDTO
{
    public class AddAuthorDTO
    {
        [Display(Name = "Yazar Adı")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
    }
}
