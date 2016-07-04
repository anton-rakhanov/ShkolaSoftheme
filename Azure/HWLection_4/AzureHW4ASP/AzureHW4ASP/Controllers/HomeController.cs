using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AzureHW4ASP.AzureServiceLogic;
using AzureHW4ASP.AzureServiceLogic.EntitiesOfTable;

namespace AzureHW4ASP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult PostBug(string BugName, string BugDesc, string AssigneeEmail)
        {
            var newBug = new BugsEntity(BugName, BugDesc, AssigneeEmail);

            var tableStorage = new AzureStorageTableService();
            tableStorage.InsertEntity(newBug);

            var queue = new AzureStorageQueueService();
            queue.AddMessage(AssigneeEmail);

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}