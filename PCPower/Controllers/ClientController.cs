using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PCPower.Models;

namespace PCPower.Controllers
{

    public class ClientController : Controller
    {
        //return View() grazina viewsa toki koks funkcijos pavadinimas ty. 
        //func openRepair(){return View()} grazins openRepair() viewsa

        private PCPowerEntities db = new PCPowerEntities();

        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult openRepair()
        {
            // openRepair() <- tokiu vardu viewsas turi but
            return View("RepairList", db.Repairs.ToList());
        }
        public ActionResult formOrder()
        {
            return View();
        }
        public ActionResult checkOrderStatus()
        {
            return View();
        }
        public ActionResult startCleanUp()
        {
            return View();

        }
        public ActionResult openServiceWindow()
        {
            //openServiceWindow() <- tokiu vardu viewsas turi but
            return View("ServiceForm");
        }

        public ActionResult openPartWindow(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Part part = db.Parts.Find(id);
            if (part == null)
            {
                return HttpNotFound();
            }
            return View("PartDetails",part);
        }

        public ActionResult wantedSelect()
        {
            return View();
        }
        public ActionResult openServiceBuilding()
        {
            return View("PCBuildingForm");
        }
        public ActionResult openRepairForm(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Repair rep = db.Repairs.Find(id);
            if (rep == null)
            {
                return HttpNotFound();
            }
            return View("RepairShow", rep);
        }
        public ActionResult repair()
        {
            return View();
        }
        public ActionResult checkData()
        {
            return View();
        }
        public ActionResult personalData()
        {
            return View();
        }
        public ActionResult openPayment()
        {
            return View();
        }
        public ActionResult addParts()
        {
            Console.WriteLine("Add");
            return View();

        }
        public ActionResult returnScreen()
        {
            return View();
        }

        //
        // GET: /Client/selectUpdateOrder/2
        public ActionResult selectUpdateOrder(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.fk_Client_Id = new SelectList(db.Clients, "Id", "User.Username", order.fk_Client_Id);
            ViewBag.fk_Shop_Id = new SelectList(db.Shops, "Id", "Name", order.fk_Shop_Id);
            ViewBag.fk_Receipt_Id = new SelectList(db.Receipts, "Id", "Id", order.fk_Receipt_Id);
            return View("OrderForm", order);
        }

        //
        // POST: /Client/selectUpdateOrder/2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult selectUpdateOrder([Bind(Include = "Id,fk_Shop_Id,fk_Receipt_Id,fk_Client_Id")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("openOrders");
            }
            ViewBag.fk_Client_Id = new SelectList(db.Clients, "Id", "User.Username", order.fk_Client_Id);
            ViewBag.fk_Shop_Id = new SelectList(db.Shops, "Id", "Name", order.fk_Shop_Id);
            ViewBag.fk_Receipt_Id = new SelectList(db.Receipts, "Id", "Id", order.fk_Receipt_Id);
            return View(order);
        }


        //
        // GET: /Client/selectDeleteOrder/5
        //public ActionResult selectDeleteOrder(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Order order = db.Orders.Find(id);
        //    if (order == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(order);
        //}

        ////
        //// POST: /Client/selectDeleteOrder/5
        //[HttpPost, ActionName("selectDeleteOrder")]
        //[ValidateAntiForgeryToken]
        //public ActionResult checkAction(int id)
        //{
        //    Order order = db.Orders.Find(id);
        //    db.Orders.Remove(order);
        //    db.SaveChanges();
        //    return RedirectToAction("openOrders");
        //}
        public ActionResult selectDeleteOrder(FormCollection fcNotUsed, int id = 0)
        {
            Order order = db.Orders.Find(id);
            if(order == null)
            {
                return HttpNotFound();
            }
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("openOrders");
        }
        public ActionResult dataUpdateSubmit()
        {
            return View();
        }
        public ActionResult check()
        {
            return View();
        }

        //
        // GET: /Client/openOrders/

        public ActionResult openOrders()
        {
            return View("OrderList", db.Orders.ToList());
        }
        public ActionResult orderSelection()
        {
            return View();
        }
        public ActionResult invokeOperation()
        {
            return View();
        }
        public ActionResult initializePurchase()
        {
            return View();
        }
        public ActionResult getParts()
        {
            return View("PartList", db.Parts.ToList());
        }
        public ActionResult invokePurchase()
        {
            return View();
        }
        public ActionResult cancel()
        {
            return View();
        }
        public ActionResult dataGather()
        {
            return View();
        }
        public ActionResult sendError()
        {
            return View();
        }
        public ActionResult sendSuccess()
        {
            return View();
        }
        public ActionResult requireReceipt()
        {
            return View();
        }
        public ActionResult formReceipt()
        {
            return View();
        }
        public ActionResult openBuildingForm()
        {
            return View();
        }
        public ActionResult checkCompatability()
        {
            return View();
        }
        public ActionResult checkSet()
        {
            return View();
        }
        public ActionResult autoChoice()
        {
            return View();
        }
        public ActionResult checkIfFullSet()
        {
            return View();
        }
        public ActionResult initializePartFind()
        {
            return View();
        }
        public ActionResult addPartsToSpecList()
        {
            return View();
        }
        public ActionResult calculateSum()
        {
            return View();
        }
        public ActionResult saveSetup()
        {
            return View();
        }
        public ActionResult purchaseSuggestion()
        {
            return View();
        }
    }
}