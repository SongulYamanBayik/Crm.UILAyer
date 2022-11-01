using Crm.EntityLayer.Concrete;
using Crm.UILAyer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILAyer.Controllers
{
    
    public class LoginController : Controller
    {

        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignInModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByNameAsync(p.UserName);
                if (await _userManager.IsLockedOutAsync(appUser))
                {
                    ModelState.AddModelError("", "Hesabınız geçiçi olarak erişime kapatılmıştır.");
                    return View();
                }
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
                if (result.Succeeded)
                {
                    await _userManager.ResetAccessFailedCountAsync(appUser);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    await _userManager.AccessFailedAsync(appUser);
                    int failedCounter = await _userManager.GetAccessFailedCountAsync(appUser);
                    ModelState.AddModelError("", $"Başarısız Giriş Sayısı: {failedCounter}");
                    if (failedCounter==3)
                    {
                        await _userManager.SetLockoutEndDateAsync(appUser, new DateTimeOffset(DateTime.Now.AddHours(5)));
                    }
                    //return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}
