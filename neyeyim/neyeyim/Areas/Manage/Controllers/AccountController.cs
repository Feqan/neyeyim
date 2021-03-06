using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using neyeyim.Areas.Manage.ViewModels;
using neyeyim.DAL;
using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _context;
        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        //public async Task<IActionResult> CreateRole()
        //{
        //    IdentityRole identityRole1 = new IdentityRole("Member");
        //    IdentityRole identityRole2 = new IdentityRole("Admin");
        //    IdentityRole identityRole3 = new IdentityRole("SuperAdmin");

        //    await _roleManager.CreateAsync(identityRole1);
        //    await _roleManager.CreateAsync(identityRole2);
        //    await _roleManager.CreateAsync(identityRole3);

        //    return Content("ok");
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AdminLoginModel login)
        {
            AppUser adminUser = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == login.UserName && x.IsAdmin);

            if (adminUser == null)
            {
                ModelState.AddModelError("", "İstifadəçi adı və ya şifrə yanlışdır!");
                return View(login);
            }

            var result = await _signInManager.PasswordSignInAsync(adminUser, login.Password, true, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "İstifadəçi adı və ya şifrə yanlışdır!");
                return View(login);
            }

            return RedirectToAction("index", "dashboard");
        }

        public async Task<IActionResult> Edit()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AppUser admin)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (_userManager.Users.Any(x => x.UserName == admin.UserName && x.Id != user.Id))
            {
                ModelState.AddModelError("UserName", "UserName already taken!");
                return View();
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            user.UserName = admin.UserName;
            user.Name = admin.Name;


            if (!string.IsNullOrWhiteSpace(admin.Password))
            {
                if (string.IsNullOrWhiteSpace(admin.CurrentPassword))
                {
                    ModelState.AddModelError("CurrentPassword", "CurrentPassword can not be emtpy");
                    return View();
                }

                var result = await _userManager.ChangePasswordAsync(user, admin.CurrentPassword, admin.Password);
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View();
                }
            }
            await _userManager.UpdateAsync(user);

            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("index", "dashboard");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("login");
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult CreateAdmin()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAdmin(AdminRegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser existUser = await _userManager.FindByNameAsync(registerModel.UserName);
            if (existUser != null)
            {
                ModelState.AddModelError("UserName", "UserName already taken");
                return View();
            }
            AppUser newUser = new AppUser()
            {
                Name = registerModel.Name,
                UserName = registerModel.UserName,
                IsAdmin = true,
            };

            var result = await _userManager.CreateAsync(newUser, registerModel.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    if (item.Code == "PasswordTooShort")
                    {
                        item.Description = "Şifrə uzuluğu 8-dən kiçik ola bilməz!";
                    }
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }
            newUser.IsAdmin = true;
            await _userManager.AddToRoleAsync(newUser, "Admin");

            return RedirectToAction("getadmins");
        }


        [Authorize(Roles = "SuperAdmin")]
        public IActionResult GetAdmins(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Users.Count() / 3d);
            List<AppUser> users = _userManager.Users.Skip((page - 1) * 3).Take(3).Where(x => x.IsAdmin && x.UserName != User.Identity.Name).ToList();
            return View(users);
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult EditAdmin(string id)
        {
            //AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUser user = _context.Users.FirstOrDefault(x => x.Id == id.ToString());

            AdminUpdateModel admin = new AdminUpdateModel()
            {
                Name = user.Name,
                UserName = user.UserName,
                Id = user.Id,
            };
            return View(admin);
        }
        [Authorize(Roles = "SuperAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAdmin(AdminUpdateModel admin)
        {
            //AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUser user = _context.Users.FirstOrDefault(x => x.Id == admin.Id);


            if (_userManager.Users.Any(x => x.UserName == admin.UserName && x.Id != user.Id))
            {
                ModelState.AddModelError("UserName", "UserName already taken!");
                return View();
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            user.UserName = admin.UserName;
            user.Name = admin.Name;

            if (!string.IsNullOrWhiteSpace(admin.Password))
            {
                if (string.IsNullOrWhiteSpace(admin.CurrentPassword))
                {
                    ModelState.AddModelError("CurrentPassword", "CurrentPassword can not be emtpy");
                    return View();
                }

                var result = await _userManager.ChangePasswordAsync(user, admin.CurrentPassword, admin.Password);
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View();
                }
            }
            await _userManager.UpdateAsync(user);

            //await _signInManager.SignInAsync(user, true);
            return RedirectToAction("getadmins");
        }
        [Authorize(Roles = "SuperAdmin")]
        public IActionResult DeleteAdmin(string id)
        {
            AppUser user = _context.Users.FirstOrDefault(x => x.Id == id);
            _userManager.DeleteAsync(user);
            _context.SaveChanges();
            return RedirectToAction("getadmins");
        }
    }
}