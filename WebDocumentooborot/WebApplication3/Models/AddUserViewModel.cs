﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebLibrary;
using WebLibrary.Models;

namespace WebApplication3.Models
{
    public class AddUserViewModel
    {
        public User GetUser()
        {
            return new User
            {
                Id= Id,
                UserName = UserName,
                FirstName = FirstName,
                SecondName= SecondName,
                LastName=LastName,
                Status=Status               
            };
        }

        [Required]
        [Display(Name ="Логин")]
        public  string UserName { get; set; }

        [Required]
        [Display(Name ="Пароль")]
        [DataType(DataType.Password)]
        public  string Password { get; set; }


        [Display(Name = "Фамилия")]
        public string LastName { get; set; }


        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Display(Name = "Отчество")]
        public string SecondName { get; set; }

        public long Id { get; set; }

        public UserStatus Status { get; set; }

    }
}