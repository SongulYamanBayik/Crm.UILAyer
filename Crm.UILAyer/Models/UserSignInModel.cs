using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILAyer.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adı değerini boş geçmeyin")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen şifre değerini boş geçmeyin")]
        public string Password { get; set; }
    }
}
