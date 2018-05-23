using Autofac;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using WebApplication3.Fold;
using WebApplication3.Models;
using WebLibrary;
using WebLibrary.Metods;

namespace WebApplication3.Controllers
{
    public class AccountController : Controller
    {
        private UserMetods userRepository;
        public SignInManager SignInManager
        {
            get { return HttpContext.GetOwinContext().Get<SignInManager>(); }
        }
        public UserManager UserManager
        {
            get { return HttpContext.GetOwinContext().Get<UserManager>(); }
        }
        public AccountController(UserMetods userRepository)
        {
            this.userRepository = userRepository;
        }
       
        public ActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Login( LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = SignInManager.PasswordSignIn(model.UserName, model.Password, false, false);
                if(result==SignInStatus.Success)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Неверное имя пользователя или пароль");
                }
            }
            return View(model);
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogOff()
        {
            SignInManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult CreateUser(string Login, string Password)
        {
            var user = new User { UserName = Login };
            var result = UserManager.CreateAsync(user, Password);
            if(result.Result.Succeeded)
            {
                SignInManager.SignIn(user, false, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach(var error in result.Result.Errors)
                {
                    ModelState.AddModelError("", "");
                }
                return RedirectToAction("Index", "Home");
            }
          
        }
       
    }
}