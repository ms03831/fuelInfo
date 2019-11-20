using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fuel_info.Models
{
    public class Price
    {
        public int ID { get; set; }
        public string type { get; set; }
        public DateTime dateUpdated { get; set; }
        public float price { get; set; }
    }

    public class PriceDBContext : DbContext
    {
        public DbSet<Price> Prices { get; set; }
    }
}
