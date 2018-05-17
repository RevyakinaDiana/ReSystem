using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
    class VersiaMap:ClassMap<Versia>
    {
        public VersiaMap()
        {
            Id(v => v.VersiaId);
            References(v => v.file);
            Map(v => v.TypeVersia).Length(20);
            Map(v => v.DataSozdania);
            Map(v => v.DataIzmenenia);
            Map(v => v.Status);
            References(v => v.Avtor);
        }
    }
}
