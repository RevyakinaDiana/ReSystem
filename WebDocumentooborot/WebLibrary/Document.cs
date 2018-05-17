using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
   public class Document: Folder
    {
        public long DocumentId { get; set; }
        public string discription { get; set; }
        public List<Version> LisVersion { get; set; }
       public string Type { get; set; }
       public List<Kommentarii> ListKomment { get; set; }
    }
}
