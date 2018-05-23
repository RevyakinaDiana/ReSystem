using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
    public class VersionMap : ClassMap<Version>
    {
        public VersionMap()
        {
            Id(v => v.VersionID).GeneratedBy.Identity();
            References(v => v.Author);
            Map(v => v.ChangeDate);
            Map(v => v.CreationDate);
            References(v => v.Document);
            References(v => v.File);
            Map(v => v.Status);
            Map(v => v.VersionNumber).Length(50);
            References(v => v.ReferredTo);
        }
    }
}
