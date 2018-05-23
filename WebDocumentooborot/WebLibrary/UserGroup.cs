using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
    public class UserGroup
    {
        public virtual long UserGroupID { get; set; }
        public virtual string GroupName { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<User> UserList { get; set; }
        public virtual File GroupAvatar { get; set; }
        public virtual Permission AccessPermition { get; set; }

    }
}
