using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models
{
    public class News
    {
        [Key]
        public long NewsID { get; set; }

        [Required(ErrorMessage ="Lütfen haber başlığını giriniz.")]
        public string Topic { get; set; }
        [Required(ErrorMessage ="Lütfen haber içeriğini giriniz.")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Lütfen haber resimi seçimini gerçekleştiriniz.")]
        public string ImagePath { get; set; }
        public DateTime PublishDate { get; set; }
        [Required(ErrorMessage ="Lütfen kategori seçiniz.")]
        public Category Category { get; set; }

    }
}
