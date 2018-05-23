using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
    public class UserGroupMap : ClassMap<UserGroup>
    {
        public UserGroupMap()
        {
            Id(u => u.UserGroupID).GeneratedBy.Identity();
            References(u => u.AccessPermition);
            Map(u => u.Description).Length(100);
            References(u => u.GroupAvatar);
            Map(u => u.GroupName).Length(50);
            HasMany(u => u.UserList)
                .Inverse()
                .Cascade.All();
        }
    }
}
