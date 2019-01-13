using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhoneMarket.Models
{
    public class DBInitilaizer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone() { Name = "XIAOMI MI8", price = 27000, Producer = "XIAOMI" });
            context.Phones.Add(new Phone() { Name = "Meizu 16th", price = 30000, Producer = "Meizu" });
            context.Phones.Add(new Phone() { Name = "Samsung S9", price = 58000, Producer = "Samsung" });

            base.Seed(context);
        }
    }
}