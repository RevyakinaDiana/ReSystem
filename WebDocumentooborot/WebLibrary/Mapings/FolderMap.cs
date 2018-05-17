using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
    class FolderMap : ClassMap<Folder>
    {
        public FolderMap()
        {
            Id(f => f.FolderId);
            Map(f => f.NameFolder).Length(30);
            Map(f => f.DataSozdania);
            Map(f => f.DataIzmenenia);
            References(f => f.Avtor);
            References(f => f.ChengdBy);
            References(f => f.Parentfolder);
            HasMany(f => f.AllowAccesTo)
                .Inverse().Cascade.All();

           
        }
    }
    }
