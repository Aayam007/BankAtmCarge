using BankCharge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankCharge.Service
{
   public interface IBankService
    {
        IEnumerable<Bank> GetBanks();
        IEnumerable<Bank> GetBankSearch(string search);
        Bank GetBankById(int? id);
        int New(Bank bank);
        int EditBank(Bank bank);
        int DeleteBank(int id);
    }
}
