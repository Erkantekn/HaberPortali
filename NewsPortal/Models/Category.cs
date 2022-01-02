using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Lütfen kategori ismi giriniz.")]
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
