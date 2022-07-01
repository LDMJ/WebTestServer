using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebTestServer.Models
{
    public class SymbolContext : DbContext
    {
        public SymbolContext()
         : base("DbConnection")
        { }

        public DbSet<oldSymbol> oldSymbols { get; set; }
        public DbSet<newSymbol> newSymbols { get; set; }
        public DbSet<requestSymbol> requestSymbols { get; set; }
    }
}