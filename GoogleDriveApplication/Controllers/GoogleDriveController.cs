using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoogleDriveApi;


namespace GoogleDriveApplication.Controllers
{
    public class GoogleDriveController : Controller
    {
        // GET: GoogleDrive
        public ActionResult Index()
        {
            FileOperations fileOperations = new FileOperations();
            return View(fileOperations.FetchListOfFiles());
        }
    }
}