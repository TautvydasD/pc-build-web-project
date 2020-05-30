using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCPower.Controllers
{
    public class ClientController : Controller
    {
        //return View() grazina viewsa toki koks funkcijos pavadinimas ty. 
        //func openRepair(){return View()} grazins openRepair() viewsa

        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult openRepair()
        {
            // openRepair() <- tokiu vardu viewsas turi but
            return View();
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
            return View();
        }

        public ActionResult openPartWindow()
        {
            return View();
        }
        public ActionResult wantedSelect()
        {
            return View();
        }
        public ActionResult openServiceBuilding()
        {
            return View();
        }
        public ActionResult openRepairForm()
        {
            return View();
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
            return View();

        }
        public ActionResult returnScreen()
        {
            return View();
        }
        public ActionResult selectUpdateOrder()
        {
            return View();
        }
        public ActionResult dataUpdateSubmit()
        {
            return View();
        }
        public ActionResult check()
        {
            return View();
        }
        public ActionResult openOrders()
        {
            return View();
        }
        public ActionResult orderSelection()
        {
            return View();
        }
        public ActionResult invokeOperation()
        {
            return View();
        }
        public ActionResult checkAction()
        {
            return View();
        }
        public ActionResult initializePurchase()
        {
            return View();
        }
        public ActionResult getParts()
        {
            return View();
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