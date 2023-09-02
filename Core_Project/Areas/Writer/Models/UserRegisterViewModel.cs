using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz.")]
        [Compare("Password", ErrorMessage = "Lütfen Aynı Şifreyi Giriniz.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Resim Yolu Giriniz.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Giriniz.")]
        public string Mail { get; set; }
    }
}
