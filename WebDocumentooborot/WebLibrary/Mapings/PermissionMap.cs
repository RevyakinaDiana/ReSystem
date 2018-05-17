using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
    class PermissionMap:ClassMap<Permission>
    {
        public PermissionMap()
        {
            Id(p => p.PermisionId);
            Map(p => p.discription).Length(100);
            Map(p => p.accesslevel);
        }
    }
}
