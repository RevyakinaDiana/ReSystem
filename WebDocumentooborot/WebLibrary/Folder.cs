using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
    public class Folder
    {
       public long FolderId { get; set; }
        public string NameFolder { get; set; }
        public Folder Parentfolder { get; set; }
        public DateTime DataSozdania { get; set; }
        public DateTime DataIzmenenia { get; set; }
        public User Avtor { get; set; }
        public User ChengdBy { get; set; }
        public List<UserGroup> AllowAccesTo { get; set; }
        public string PathSearch()
        {
          
            Folder folder = new Folder();

            if (folder.Parentfolder != null)
                return folder.Parentfolder.PathSearch() + @"\" + folder.NameFolder;
            else
                return Parentfolder.PathSearch() + @":\" + NameFolder;
        }
        }



    }
   
    
   
   
   
   
  

