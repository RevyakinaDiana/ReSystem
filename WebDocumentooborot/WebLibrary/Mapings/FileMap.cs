using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
    class FileMap: ClassMap<File>
    {
        public FileMap()
        {
            Id(f1 => f1.FileId);
            Map(f1 => f1.type).Length(30);
            Map(f1 => f1.size);
        }
    }
}
