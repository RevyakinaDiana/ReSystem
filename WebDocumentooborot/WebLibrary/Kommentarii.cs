using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
   public class Kommentarii
    {
       public long KommentariiId { get; set; }
      public  string text { get; set; }
        public User Sender { get; set; }
       public Kommentarii AnswerTo { get; set; }
    }
}
