using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using presentence.Context;
using presentence.Migrations;
using ServiceLayer.CourseService;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using Web.ViewModel;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        private ICourseService _courseService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        private PresistanceContext _context;
       
        public AccountController(UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager, ICourseService courseService, PresistanceContext context)

           
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _courseService= courseService;
            _context= context;
        }
      
        public IActionResult Index()

        {
             
            return View();
        }

        public IActionResult GetAction()

        {
            

            return View();
        }
        [HttpGet]
        public IActionResult Register()

        {
            var viewModel = new RegisterViewModel
            {
              Courses  = _courseService.GetCourses().OrderBy(c => c.Title)
            };
            

           
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            try {
                if (ModelState.IsValid)
                {
                    var user = new ApplicationUser
                    {
                        UserName = new MailAddress(model.Email).User,
                        Email = model.Email,
                        FirstName = model.FristName,
                        LastName = model.LastName,
                        PhoneNumber = model.PhoneNumber,
                        CourseId = model.CourseId,


                    };

                    var result = await _userManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        //await _userManager.AddToRoleAsync(user, "User");
                        await _signInManager.SignInAsync(user, isPersistent: false);

                        return RedirectToAction("index", "Admin");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(String.Empty, error.Description);
                    }

                    // ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

                }
                model.Courses = _courseService.GetCourses().OrderBy(c => c.Title);
                return View(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var username = new EmailAddressAttribute().IsValid(user.Email) ? new MailAddress(user.Email).User : user.Email;

                    var result = await _signInManager.PasswordSignInAsync(username, user.Password, user.RememberMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                }

                return View(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
