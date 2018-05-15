using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
    public class Folder
    {
        long FolderId { get; set; }
        string NameFolder { get; set; }
        Folder Parentfolder { get; set; }
        DateTime DataSozdania { get; set; }
        DateTime DataIzmenenia { get; set; }
        User Avtor { get; set; }
        User ChengdBy { get; set; }
        List<UserGroup> AllowAccesTo { get; set; }
        public void SearchPath()
        {
            string partialpath="", fullpath="";
            Folder folder = new Folder();
            while (folder.Parentfolder != null)
            {
                if (folder.Parentfolder != null)
                {
                    partialpath = fullpath;
                    fullpath = folder.NameFolder + @"\" + partialpath;
                    folder = Parentfolder;
                }
                else
                {
                    partialpath = fullpath;
                    fullpath = folder.NameFolder + @"\" + partialpath;
                }
            }
        }



    }
   
    
   
   
   
   
  
}
