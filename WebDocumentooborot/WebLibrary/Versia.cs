using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
    class Versia
    {
        long VersiaId { get; set; }
        File file { get; set; }
        string TypeVersia { get; set; } //на случай, если версия имеет формат 3.10.122
        DateTime DataSozdania { get; set; }
        DateTime DataIzmenenia { get; set; }
        User Avtor { get; set; }
        Enum Status { get; set; }

    }
}
