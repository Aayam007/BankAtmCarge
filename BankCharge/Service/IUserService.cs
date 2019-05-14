using BankCharge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankCharge.Service
{
 public   interface IUserService
    {
        int New(UserDetail userDetail);
    }
}
