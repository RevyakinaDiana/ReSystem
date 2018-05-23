using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Fold;
using WebApplication3.Models;
using WebLibrary.Metods;

namespace WebApplication3.Controllers
{
    public class UserGroupController : Controller
    {
        public UserManager UserManager
        {
            get { return HttpContext.GetOwinContext().Get<UserManager>(); }
        }
        
        private UserGroupMetods groupRepository;
        public UserGroupController( UserGroupMetods groupRepository)
        {
          
            this.groupRepository = groupRepository;
        }
        // GET: UserGroup
       
        public ActionResult GroupUser()
        {
            var model = new GroupUserViewModel
            {
                UserGroups = groupRepository.GetAll()
            };
            return View(model);
        }
    }
}