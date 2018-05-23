using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using WebApplication3.Fold;
using WebLibrary;

namespace WebApplication3.Fold
{
    public class SignInManager:SignInManager<User, long>
    {
        public SignInManager(UserManager<User, long> userManager, 
            IAuthenticationManager AuthenticationManager)
            :base(userManager, AuthenticationManager)
        {

        }
        public void SignOut()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }
    }
}