using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
   public class Versia
    {
        public   long VersiaId { get; set; }
        public  File file { get; set; }
        public string TypeVersia { get; set; } //на случай, если версия имеет формат 3.10.122
        public DateTime DataSozdania { get; set; }
        public DateTime DataIzmenenia { get; set; }
        public User Avtor { get; set; }
        public Enum Status { get; set; }

    }
}
