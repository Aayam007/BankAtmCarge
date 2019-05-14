using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankCharge.Models
{
    public class Bank
    {
        public int BankId { get; set; }
        public string Name { get; set; }

      
        public string Image { get; set; }
       
        public IFormFile ImageUrl { get; set; }
        public int Charge { get; set; }
        public string CardType { get; set; }
      

    }
}
