using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebLibrary;
using WebLibrary.Metods;

namespace WebApplication3.Controllers
{
    [Authorize]
    public class FolderController : Controller
    {
        private FolderRepository folderRepository;
        public FolderController(FolderRepository folderRepository)
        {
            this.folderRepository = folderRepository;
        }
        public ActionResult Index(long? id)
        {
            var folder = id.HasValue ? folderRepository.Load(id.Value) : null;
            var model = new FolderViewModel
            {
                CurrentFolder = folder,
                ParentFolder = folder != null && folder.ParentFolder != null ? folder.ParentFolder : null,
                Folders = folderRepository.GetFolders(id)
            };
            return View(model);
        }

        public ActionResult Create(long? id)
        {
            var folder = id.HasValue ? folderRepository.Load(id.Value) : null;
            return View(new FolderEditViewModel
            {
                ParentFolder = folder
            });
        }
        [HttpPost]
        public ActionResult Create(FolderEditViewModel model)
        {
            var parent = model.ParentFolder != null && model.ParentFolder.FolderID > 0 ?
                folderRepository.Load(model.ParentFolder.FolderID) :
                null;
            var folder = new Folder
            {
                Foldername = model.Name,
                ParentFolder = parent
            };
            folderRepository.Save(folder);
            return RedirectToAction("Index", new { id = parent != null ? parent.FolderID : folder.FolderID });
        }

    }
}