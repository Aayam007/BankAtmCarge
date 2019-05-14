using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankCharge.Models
{
    public class UserDetail
    {
        public int AppId { get; set; }
        public string BankName { get; set; }
        public  String CardNumber { get; set; }
        public string CardType { get; set; }
    }
}
