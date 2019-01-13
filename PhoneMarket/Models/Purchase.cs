using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneMarket.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }

        public int PhoneId { get; set; }

        public DateTime DataTime { get; set; }

        public string Email { get; set; }

        public string FIO { get; set; }

        public string Address { get; set; }
    }
}
