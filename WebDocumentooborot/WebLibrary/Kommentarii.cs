using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
    class Kommentarii
    {
        long KommentariiId { get; set; }
        string text { get; set; }
        User Sender { get; set; }
        Kommentarii AnswerTo { get; set; }
    }
}
