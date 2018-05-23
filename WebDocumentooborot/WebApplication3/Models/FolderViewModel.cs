using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLibrary;

namespace WebApplication3.Models
{
    public class FolderViewModel
    {
        public Folder ParentFolder { get; set; }
        public Folder CurrentFolder { get; set; }
        public IList<Folder> Folders { get; set; }
    }
}