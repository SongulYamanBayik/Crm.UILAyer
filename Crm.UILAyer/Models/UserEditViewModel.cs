using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILAyer.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage ="Ad Alanı Gereklidir")]
        [StringLength(20, ErrorMessage = "En Fazla 20 Karakter Giriniz.")]
        [DisplayName("Kullanıcının Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı Gereklidir")]
        [DisplayName("Kullanıcının Soyadı")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Mail Alanı Gereklidir")]
        [DisplayName("Kullanıcının Maili")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon Alanı Gereklidir")]
        [DisplayName("Kullanıcının Telefonu")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Gereklidir")]
        [DisplayName("Kullanıcının Şifresi")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Gereklidir")]
        [DisplayName("Kullanıcının Şifresi Tekrar")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Görsel Gereklidir")]
        [DisplayName("Kullanıcının Görseli")]
        public string ImageUrl { get; set; }

        public IFormFile Image { get; set; }
    }
}
