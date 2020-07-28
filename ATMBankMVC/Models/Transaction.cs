using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATMBankMVC.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int CheckingAccountId { get; set; }
    }
}