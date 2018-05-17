using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
    public class UserGroup
    {
       public long UserGroupId { get; set; }
       public string NameUserGroup { get; set; }
       public string discription { get; set; }
       public List<User> ListUser { get; set; }
      public File Avatarka { get; set; }
       public Permission permission { get; set; }
    }
}
