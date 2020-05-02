using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PCPower.Models;

namespace PCPower.Controllers
{
    public class OrdersController : Controller
    {
        private PCPBaseEntities db = new PCPBaseEntities();

        // GET: Orders
        public ActionResult Index()
        {
            var orders = db.Orders.Include(o => o.Client).Include(o => o.Part).Include(o => o.Receipt).Include(o => o.Repair).Include(o => o.Shop);
            return View(orders.ToList());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
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
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.fk_Client_Id = new SelectList(db.Clients, "Id", "Id");
            ViewBag.fk_Part_Id = new SelectList(db.Parts, "Id", "Id");
            ViewBag.fk_Receipt_Id = new SelectList(db.Receipts, "Id", "Number");
            ViewBag.fk_Repair_Id = new SelectList(db.Repairs, "Id", "Id");
            ViewBag.fk_Shop_Id = new SelectList(db.Shops, "Id", "Name");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,fk_Repair_Id,fk_Shop_Id,fk_Receipt_Id,fk_Client_Id,fk_Part_Id")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.fk_Client_Id = new SelectList(db.Clients, "Id", "Id", order.fk_Client_Id);
            ViewBag.fk_Part_Id = new SelectList(db.Parts, "Id", "Id", order.fk_Part_Id);
            ViewBag.fk_Receipt_Id = new SelectList(db.Receipts, "Id", "Number", order.fk_Receipt_Id);
            ViewBag.fk_Repair_Id = new SelectList(db.Repairs, "Id", "Id", order.fk_Repair_Id);
            ViewBag.fk_Shop_Id = new SelectList(db.Shops, "Id", "Name", order.fk_Shop_Id);
            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
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
            ViewBag.fk_Client_Id = new SelectList(db.Clients, "Id", "Id", order.fk_Client_Id);
            ViewBag.fk_Part_Id = new SelectList(db.Parts, "Id", "Type", order.fk_Part_Id);
            ViewBag.fk_Receipt_Id = new SelectList(db.Receipts, "Id", "Number", order.fk_Receipt_Id);
            ViewBag.fk_Repair_Id = new SelectList(db.Repairs, "Id", "Id", order.fk_Repair_Id);
            ViewBag.fk_Shop_Id = new SelectList(db.Shops, "Id", "Name", order.fk_Shop_Id);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,fk_Repair_Id,fk_Shop_Id,fk_Receipt_Id,fk_Client_Id,fk_Part_Id")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.fk_Client_Id = new SelectList(db.Clients, "Id", "Id", order.fk_Client_Id);
            ViewBag.fk_Part_Id = new SelectList(db.Parts, "Id", "Type", order.fk_Part_Id);
            ViewBag.fk_Receipt_Id = new SelectList(db.Receipts, "Id", "Number", order.fk_Receipt_Id);
            ViewBag.fk_Repair_Id = new SelectList(db.Repairs, "Id", "Id", order.fk_Repair_Id);
            ViewBag.fk_Shop_Id = new SelectList(db.Shops, "Id", "Name", order.fk_Shop_Id);
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
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
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
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
