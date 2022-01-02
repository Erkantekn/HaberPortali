using System.ComponentModel.DataAnnotations;

namespace NewsPortal.Models.ViewModels {

    public class LoginModel {

        [Required(ErrorMessage ="Kullanıcı Adı Boş Bırakılamaz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Boş Bırakılamaz.")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
