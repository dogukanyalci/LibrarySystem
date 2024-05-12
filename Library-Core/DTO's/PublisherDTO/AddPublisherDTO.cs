using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Core.DTO_s.PublisherDTO
{
    public class AddPublisherDTO
    {
        [Display(Name = "Yayınevi Adı")]
        public string Name { get; set; }
    }
}
