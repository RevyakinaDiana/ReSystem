using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
    public class FolderMap : ClassMap<Folder>
    {
        public FolderMap()
        {
            Id(f => f.FolderID).GeneratedBy.Identity();
            Map(f => f.ChangeDate);
            HasMany(f => f.AllowAccessTo)
                .Inverse()
                .Cascade.All();
            References(f => f.Author);
            References(f => f.ChangedBy);
            Map(f => f.CreationDate);
            Map(f => f.Foldername).Length(100);
            References(f => f.ParentFolder);
        }
    }
}
