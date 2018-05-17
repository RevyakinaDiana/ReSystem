using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
    class UserGroupMap: ClassMap<UserGroup>
    {
        public void UserGroup()
        {
            Id(ug => ug.UserGroupId);
            Map(ug => ug.NameUserGroup).Length(30);
            Map(ug => ug.discription).Length(100);
            References(ug => ug.Avatarka);
            HasMany(ug => ug.ListUser)
                .Inverse().Cascade.All();
            References(ug => ug.permission);
        }
    }
}
