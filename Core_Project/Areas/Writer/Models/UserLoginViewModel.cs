using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Lütfen Geçerli Bir Kullanıcı Adı Giriniz.")]
        public string Username { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreniz hesabınızla eşleşmemektedir.")]
        public string Password { get; set; }
    }
}
