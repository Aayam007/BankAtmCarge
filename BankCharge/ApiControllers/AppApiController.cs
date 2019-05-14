using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankCharge.Models;
using BankCharge.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankCharge.ApiControllers
{
    
    public class AppApiController : Controller
    {
        private readonly IUserService _userService;
        public AppApiController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("api/UserDetail")]
        [HttpPost]
        public  dynamic UserDetail(UserDetail userDetail )
        {


            return _userService.New(userDetail);
        }
    }
}