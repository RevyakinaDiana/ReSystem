using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
    class User
    {
        long UserId { get; set; }
        string login { get; set; }
        string password { get; set; }
        string Sol { get; set; }
        string surname { get; set; }
        string name { get; set; }

        string patronymic { get; set; }
        string Email { get; set; }
        DateTime DateBirth { get; set; }
        Enum Status { get; set; }
    }
}
