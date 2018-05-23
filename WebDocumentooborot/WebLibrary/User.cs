﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.Models;

namespace WebLibrary
{
  public  class User:IUser<long>
    {
        public virtual long Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string Salt { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string SecondName { get; set; }
        public virtual File Avatar { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DateofBirth { get; set; }
        public virtual UserStatus Status { get; set; }
        public virtual UserGroup InGroup { get; set; }

        

       
    }
}
