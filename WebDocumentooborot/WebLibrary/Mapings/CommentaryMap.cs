using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
    class CommentaryMap : ClassMap<Commentary>
    {
        public CommentaryMap()
        {
            Id(c => c.CommentaryID).GeneratedBy.Identity();
            References(c => c.AnswerTo);
            References(c => c.PinnedFile);
            References(c => c.Sender);
            Map(c => c.Text).Length(200);
            References(c => c.ReferredTo);
        }
    }
}
