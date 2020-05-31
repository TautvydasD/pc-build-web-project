using PCPower.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PCPower.Models;

namespace PCPower.Controllers
{
    public class WorkerController : Controller
    {
        private PCPowerEntities db = new PCPowerEntities();
        // GET: Worker
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult selectCreatePart()
        {
            return View();
        }
        public ActionResult submitData()
        {
            return View();
        }
        public ActionResult validateNewPartData()
        {
            return View();
        }
        public ActionResult openWorkerPartsList()
        {
            return View("PartList", db.Parts.ToList());
        }
        public ActionResult selectPartOptions()
        {
            return View();
        }
        public ActionResult selectUpdateOptions()
        {
            return View();
        }
        public ActionResult submitUpdatedData()
        {
            return View();
        }
        public ActionResult selectAction()
        {
            return View();
        }
        public ActionResult selectDeletePart()
        {
            return View();
        }
        public ActionResult openWorkerComputersList()
        {
            return View("ComputerList", db.Computers.ToList());
        }
        public ActionResult selectComputerOptions()
        {
            return View();
        }
        public ActionResult selectCreateComputer()
        {
            return View();
        }
        public ActionResult validateNewComputerData()
        {
            return View();
        }
        public ActionResult selectUpdateComputer()
        {
            return View();
        }
        public ActionResult selectDeleteComputer()
        {
            return View();
        }
        public ActionResult openWorkerRepairsList()
        {
            return View("RepairList", db.Repairs.ToList());
        }
        public ActionResult selectRepairOptions()
        {
            return View();
        }
        public ActionResult selectCreateRepair()
        {
            return View("RepairForm");
        }
        public ActionResult validateNewRepairData()
        {
            return View();
        }
        public ActionResult selectUpdateRepair()
        {
            return View();
        }
        public ActionResult selectDeleteRepair()
        {
            return View();
        }
        public ActionResult openRepairChatForm()
        {
            return View();
        }
        public ActionResult openUpdatedPartsList() //?? butu uzteke tiesiog upenPartsList
        {
            return View();
        }
        public ActionResult openUpdatedRepairsList() // same
        {
            return View();
        }
        public ActionResult openUpdatedComputersList() // same
        {
            return View();
        }
        public ActionResult sendTelegramMessage() // same
        {
            return View();
        }

        // GET: Repairs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Repairs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Number,Status," +
                                                   "DeviceID,fk_Order_Id,fk_Worker_Id")] Repair repair)
        {
            if (ModelState.IsValid)
            {
                db.Repairs.Add(repair);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else return RedirectToAction("openWorkerRepairsList");

        }

    }
}