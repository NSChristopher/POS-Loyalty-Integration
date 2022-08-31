using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Customer
    {
        public string customerIdentificationNumber;
        public string emailId;
        public string phoneNumber;
        public string name;
        public string firstName;
        public string lastName;
        public string birthDate;
        public int loyaltyPoints;
        public bool isLoyaltyCustomer;
        public DateTime lastUpdated;
        public DateTime dateCreated;
        public DateTime dateOfBirth;
        public List<LoyaltyDetails> CustomerLoyalties;
    }
}
