using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace WebLibrary.Mapings
{
    public class DocumentMap : SubclassMap<Document>
    {
        public DocumentMap()
        {

            //в наследуемых добавлять ID не надо
            Map(d => d.Description).Length(100);
            Map(d => d.DocumentType).Length(10);
            HasMany(d => d.VersionList)
                .Inverse()
                .AsList();
            HasMany(d => d.CommentaryList)
                .Inverse()
                .AsList();
            References(d => d.File);
        }
    }
}
