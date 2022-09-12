using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class LoyaltyDetails
    {
        public string date { get; set; }


        public string ticketID { get; set; }
        public string type { get; set; }
        public double amount { get; set; }
        public string notes { get; set; }
    }
}