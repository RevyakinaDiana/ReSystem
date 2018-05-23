using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
    public class FileMap : ClassMap<File>
    {
        public FileMap()
        {
            Id(f => f.FileId).GeneratedBy.Identity();
            Map(f => f.Path).Length(100);
            Map(f => f.Size);
            Map(f => f.Type);
            Map(f => f.Content).Length(int.MaxValue);
        }
    }
}
