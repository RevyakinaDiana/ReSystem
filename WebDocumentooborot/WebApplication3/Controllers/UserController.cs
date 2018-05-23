using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Fold;
using WebApplication3.Models;
using WebLibrary;
using WebLibrary.Metods;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        
        public UserManager UserManager
        {
            get { return HttpContext.GetOwinContext().Get<UserManager>(); }
        }
        private UserMetods userRepository;
        
        public UserController(UserMetods userRepository)
        {
            this.userRepository = userRepository;
         
        }
        // GET: User
        public ActionResult Index()
        {
            var model = new UsersListViewModel
            {
                User = userRepository.GetAll()
            };
                
            return View(model);
        }
       
        
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(AddUserViewModel model)
        {
            var user = model.GetUser();
            var result = UserManager.CreateAsync(user, model.Password);
            if (!result.Result.Succeeded)
            {            
                foreach (var error in result.Result.Errors)
                {
                    ModelState.AddModelError("", error);
                }
            }
            return RedirectToAction("Index", "User");
        }

        [HttpPost]
        public ActionResult Change(EditViewModel model)
        {

            var u = userRepository.Load(model.Id);

            u.Id = model.Id;
            u.UserName = model.UserName;
            u.FirstName = model.FirstName;
            u.LastName = model.LastName;
            u.SecondName = model.SecondName;
            u.Email = model.Email;
            u.Status = model.Status;
            u.DateofBirth = Convert.ToDateTime(model.DateofBirth);
            userRepository.Save(u);
           // var result = UserManager.Update(u);
           /*if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(" ", error);
                }
            }*/
            /* User user = UserManager.FindByEmail(User.Identity.Name);

             if (user != null)
             {
                 user.LastName = model.LastName.ToString();
                 IdentityResult result = UserManager.Update(user);

                 if (result.Succeeded)
                 {
                     return RedirectToAction("Index", "Home");
                 }
                 else
                 {
                     ModelState.AddModelError("", "Что-то пошло не так");
                 }
             }
             else
             {
                 ModelState.AddModelError("", "Пользователь не найден");
             }*/
            return RedirectToAction("Index", "User");
        }
        public ActionResult Change(long id)
        {
            var user = userRepository.Load(id);
            return View(new EditViewModel
            {
               Id = user.Id,
                FirstName = user.FirstName,
               UserName = user.UserName,
               Status = user.Status,
               LastName = user.LastName,
               SecondName=user.SecondName,
               Email=user.Email          
            });
          
              
          


        }


    }

   
}