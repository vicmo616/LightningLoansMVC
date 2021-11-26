using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LightningLoansMVC.Models
{
    public class LoanPayment
    {
        public int Month { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public decimal Payment { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal MonthlyPrinciple { get; set; }
        public decimal MonthlyInterest { get; set; }
        public decimal TotalInterest { get; set; }
        public decimal Balance { get; set; }
    }
}
