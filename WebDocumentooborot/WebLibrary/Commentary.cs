using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
   public class Commentary
    {
        public virtual long CommentaryID { get; set; }
        public virtual string Text { get; set; }
        public virtual User Sender { get; set; }
        public virtual File PinnedFile { get; set; }
        public virtual Commentary AnswerTo { get; set; }
        public virtual Document ReferredTo { get; set; }
    }
}
