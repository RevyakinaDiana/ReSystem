using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
  public  class User
    {
      public  long UserId { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string Sol { get; set; }
        public string surname { get; set; }
        public string name { get; set; }

        public string patronymic { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }
        public Enum Status { get; set; }
        public File Avatar { get; set; }
    }
}
