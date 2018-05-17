using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
    class KommentariiMap: ClassMap<Kommentarii>
    {
        public KommentariiMap()
        {
            Id(k => k.KommentariiId);
            Map(k => k.text).Length(100);
            References(k => k.Sender);
            References(k => k.AnswerTo);
        }
    }
}
