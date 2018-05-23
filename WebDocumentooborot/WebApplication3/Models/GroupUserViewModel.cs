using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLibrary;

namespace WebApplication3.Models
{
    public class GroupUserViewModel
    {
        public List<UserGroup> UserGroups { get; set; }
        public GroupUserViewModel()
        {
            UserGroups = new List<UserGroup>();
        }
    }
}