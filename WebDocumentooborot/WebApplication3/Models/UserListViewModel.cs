using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLibrary;

namespace WebApplication3.Models
{
    public class UsersListViewModel
    {
        public List<User> User { get; set; }
       public UsersListViewModel()
        {
            User = new List<User>();
        }
    }
}