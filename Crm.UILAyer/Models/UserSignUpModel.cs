using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILAyer.Models
{
    public class UserSignUpModel
    {
        [Required(ErrorMessage ="Lütfen ad değerini boş geçmeyin")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Lütfen soyad değerini boş geçmeyin")]
        public string Surname { get; set; }



        [Required(ErrorMessage = "Lütfen cinsiyet değerini boş geçmeyin")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Lütfen mail değerini boş geçmeyin")]
        public string Mail { get; set; }


        [Required(ErrorMessage = "Lütfen kullanıcı adı değerini boş geçmeyin")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen şifre değerini boş geçmeyin")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor lütfen kontrol ediniz.")]
        public string ConfirmPassword { get; set; }
    }
}
