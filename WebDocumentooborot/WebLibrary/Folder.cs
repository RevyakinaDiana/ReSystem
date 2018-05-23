using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary
{
    public class Folder
    {
        public virtual long FolderID { get; set; }
        public virtual string Foldername { get; set; }
        public virtual Folder ParentFolder { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime ChangeDate { get; set; }
        public virtual User Author { get; set; }
        public virtual User ChangedBy { get; set; }
        public virtual List<Permission> AllowAccessTo { get; set; }
       /* public string PathSearch()
        {
          
            Folder folder = new Folder();

            if (folder.Parentfolder != null)
                return folder.Parentfolder.PathSearch() + @"\" + folder.NameFolder;
            else
                return Parentfolder.PathSearch() + @":\" + NameFolder;
        }*/
        }



    }
   
    
   
   
   
   
  

