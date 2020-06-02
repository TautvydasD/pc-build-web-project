using PCPower.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PCPower.Models;
using System.Net;
using System.Data.Entity;
using System.Diagnostics;
using Telegram.Bot;

namespace PCPower.Controllers
{
    public class WorkerController : Controller
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("1074622530:AAGZTuwIoCXTvvvG7rktoTvFjNiAb_GMSnY");
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
            return View("RepairForm", new Repair());
        }
        public ActionResult selectUpdateRepair(int id)
        {
            return View("RepairForm", db.Repairs.Find(id));
        }
        public ActionResult selectDeleteRepair(int id)
        {
            return View("RepairDelete", db.Repairs.Find(id));
        }
        public ActionResult openRepairChatForm()
        {
            return View("RepairMessage");
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

        [HttpPost]
        public ActionResult sendTelegramMessage(int? id, int? userId)
        {
            return View("RepairList", db.Repairs.ToList());
        }

        // POST: Repairs/CreateEdit
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult submitCreateEdit(Repair repair)
        {
            if (ModelState.IsValid)
            {
                if (repair.Id <= 0)
                {
                    db.Repairs.Add(repair);
                    var msg = "Data inserted successfully";
                    TempData["ConfirmMessage"] = msg;
                }
                else
                {
                    db.Entry(repair).State = EntityState.Modified;
                    var msg = "Data updated successfully";
                    TempData["ConfirmMessage"] = msg;
                }
                db.SaveChanges();
                return RedirectToAction("openWorkerRepairsList");
            }
            else
            {
                var msg = "Something went wrong!";
                TempData["ConfirmMessage"] = msg;
            }

            return View();
        }

        // GET: Repairs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Repair repair = db.Repairs.Find(id);
            if (repair == null)
            {
                return HttpNotFound();
            }
            return View(repair);
        }

        // POST: Repairs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Repair repair = db.Repairs.Find(id);
            db.Repairs.Remove(repair);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}