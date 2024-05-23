using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpacDYNa.Models;
using SpacDYNa.ViewModels;

namespace SpacDYNa.Controllers
{
    public class AccountController1(UserManager<AppUser> _manager,SignInManager<AppUser> _signin) : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Register(RegisterVM vm)

        {
            if (!ModelState.IsValid)
                return View(vm);
            AppUser user = new AppUser
            {
                Name = vm.Name,
                SurName = vm.Surname,
                UserName = vm.UserName,
                Email = vm.gmail
            };
            var result = await _manager.CreateAsync(user, vm.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors) { ModelState.AddModelError("", "isdifadeci yaranmadi"); }
                return View(vm);
         
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginVM vm)
        {
           if (!ModelState.IsValid) { return View(); }
           AppUser user=await _manager.FindByNameAsync(vm.UserName);
            if (user == null) { ModelState.AddModelError("", "Isdifadeci adi ve ya parol yalnisdir"); }
           var data=await _signin.CheckPasswordSignInAsync(user, vm.Password,false);
            if (!data.Succeeded) { ModelState.AddModelError("", "Isdifadeci adi ve ya parol yalnisdir"); }
            return RedirectToAction(nameof(Index));
            
        }

        public async Task<IActionResult> Logout()
        {
            await _signin.SignOutAsync();
            return View();
        }   
    }
}
