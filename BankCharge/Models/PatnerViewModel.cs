using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankCharge.Models
{
    public class PatnerViewModel
    {
        public Bank Bank { get; set; }
       public List<Bank> PatnerBank { get; set; }
    }
}
