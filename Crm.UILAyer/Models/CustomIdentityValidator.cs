using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILAyer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Şifre en az {length} karakter olmalıdır"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Şifre en az 1 tane küçük harf içermelidir"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Şifre en az 1 tane büyük harf içermelidir"
            };
        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "DuplicateEmail",
                Description = $"{email} zaten sisteme kayıtlı, lütfen farklı bir mail adresi deneyiniz"
            };
        }
    }
}
