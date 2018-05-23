using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
   public class Version
    {
        public virtual long VersionID { get; set; }
        public virtual File File { get; set; }
        public virtual string VersionNumber { get; set; } //на случай если версия имеет формат "3.12.1554"
        public virtual Document Document { get; set; } //в версии есть ссылка на документ, а в документе - лист версий - ?
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime ChangeDate { get; set; }
        public virtual User Author { get; set; }
        public virtual Enum Status { get; set; }
        public virtual Document ReferredTo { get; set; }

    }
}
