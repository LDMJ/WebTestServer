using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTestServer.Models;

namespace WebTestServer.Controllers
{
    public class HomeController : Controller
    {
        SelectDataBase param = new SelectDataBase();
        string datedb;
        DateTime date = new DateTime();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            DateTime date = new DateTime();
            string datedb;
            using (SymbolContext db = new SymbolContext())
            {
                date = DateTime.Now;
                datedb = date.ToShortTimeString();
                List<int> id = new List<int>();
                List<string> symbol = new List<string>();
                var value = db.newSymbols;
                requestSymbol sym = new requestSymbol() { requestSym = "абвн", date = datedb};
                db.requestSymbols.Add(sym);
                db.SaveChanges();
                foreach (newSymbol u in value)
                {
                    id.Add(u.Id);
                    symbol.Add(u.sym);
                }
            }    
                ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            using (SymbolContext db = new SymbolContext())
            {
                List<string> oldValues = param.oldSymbolName();
                List<string> newValues = param.newSymbolName();
                List<int> idsym = param.oldSymbolId();
                string changedText;
                string resultText;
                string someTypeText = "аабззфвввэээ";
                for (int i = 0; i < idsym.Count; i++)
                {
                    someTypeText = someTypeText.Replace(oldValues[i], newValues[i]);
                }
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}