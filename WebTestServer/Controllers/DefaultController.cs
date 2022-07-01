using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using WebTestServer.Models;

namespace WebTestServer.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DefaultController : ApiController
    {
        string datedb;
        DateTime date = new DateTime();
        SelectDataBase param = new SelectDataBase();

        [AcceptVerbs("GET")]
        [Route("Ping/{id}")]
        public async Task<IHttpActionResult> Ping(string id)
        {
            using (SymbolContext db = new SymbolContext())
            {
                List<string> oldValues = param.oldSymbolName();
                List<string> newValues = param.newSymbolName();
                List<int> idsym = param.oldSymbolId();
                
                var value = db.newSymbols;
                date = DateTime.Now;
                datedb = date.ToShortTimeString();
                requestSymbol sym = new requestSymbol { requestSym = id, date = datedb };
                db.requestSymbols.Add(sym);
                db.SaveChanges();
                for (int i = 0; i < idsym.Count; i++)
                {
                    id = id.Replace(oldValues[i], newValues[i]);
                }

            }
                return Ok(new { data = id });
        }
    }
}
