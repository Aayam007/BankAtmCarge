using BankCharge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankCharge.Service
{
    public interface IPatnerService
    {
        IEnumerable<Patner> GetPatners();
        IEnumerable<Patner> GetPatnerSearch(string search);
        Patner GetPatnerById(int? id);
        int New(Patner patner);
        int EditPatner(Patner patner);
        int DeletePatner(int id);
    }
}
