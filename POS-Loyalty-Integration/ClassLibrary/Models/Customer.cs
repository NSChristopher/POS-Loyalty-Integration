using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Customer
    {
        public string customerIdentificationNumber { get; set; }
        public string emailId { get; set; }
        public string phoneNumber { get; set; }
        public string name { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthDate { get; set; }
        public int loyaltyPoints { get; set; }
        public bool isLoyaltyCustomer { get; set; }
        public DateTime lastUpdated { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateOfBirth { get; set; }
        public List<LoyaltyDetails> CustomerLoyalties { get; set; }
    }
}
