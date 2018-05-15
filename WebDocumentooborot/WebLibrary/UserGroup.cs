using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
    class UserGroup
    {
        long UserGroupId { get; set; }
        string NameUserGroup { get; set; }
        string discription { get; set; }
        List<User> ListUser { get; set; }
        File Avatarka { get; set; }
        Permission permission { get; set; }
    }
}
