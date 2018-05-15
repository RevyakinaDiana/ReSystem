using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
    class Document: Folder
    {
        long DocumentId { get; set; }
        string discription { get; set; }
        List<Version> LisVersion { get; set; }
        string Type { get; set; }
        List<Kommentarii> ListKomment { get; set; }
    }
}
