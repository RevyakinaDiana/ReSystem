using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace WebLibrary.Mapings
{
    class DocumentMap: SubclassMap<Document>
    {
        public  DocumentMap()
        {

            Map(d => d.discription).Length(100);
            HasMany(d => d.LisVersion)
                .Inverse().Cascade.All();
            Map(d => d.Type).Length(20);
            HasMany(d => d.ListKomment)
                .Inverse().Cascade.All();
        }
    }
}
