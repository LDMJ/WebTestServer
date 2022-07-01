using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTestServer.Models;

namespace WebTestServer
{
    public class SelectDataBase
    {
       
        public List<int> newSymbolId()
        {
            List<int> idSym = new List<int>();
            using (SymbolContext db = new SymbolContext())
            {

                var value = db.newSymbols;
                foreach (newSymbol u in value)
                {
                    idSym.Add(u.Id);
                }
            }
            return idSym;
        }
        public List<string> newSymbolName()
        {
            List<string> nameSym = new List<string>();
            using (SymbolContext db = new SymbolContext())
            {

                var value = db.newSymbols;
                foreach (newSymbol u in value)
                {
                    nameSym.Add(u.sym);
                }
            }
            return nameSym;
        }
        public List<int> oldSymbolId()
        {
            List<int> idSym = new List<int>();
            using (SymbolContext db = new SymbolContext())
            {

                var value = db.oldSymbols;
                foreach (oldSymbol u in value)
                {
                    idSym.Add(u.Id);
                }
            }
            return idSym;
        }
        public List<string> oldSymbolName()
        {
            List<string> nameSym = new List<string>();
            using (SymbolContext db = new SymbolContext())
            {

                var value = db.oldSymbols;
                foreach (oldSymbol u in value)
                {
                    nameSym.Add(u.sym);
                }
            }
            return nameSym;
        }
    }
}