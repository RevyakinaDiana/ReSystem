using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLibrary;
using WebLibrary.Models;

namespace WebApplication3.Models
{
    
    public class EditViewModel
    {
       /* public User UserGet()
        {
            return new User
            {
                Id = Id,
                LastName = LastName,
                UserName=UserName,
                SecondName=SecondName,
                Status=Status,
                DateofBirth=DateofBirth,
                Email=Email,
                FirstName=FirstName
            };
        }*/
        //public string LastName {get;set;}
       
            public long Id { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public UserStatus Status { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Email { get; set; }
        public string SecondName { get; set; }
    }
}