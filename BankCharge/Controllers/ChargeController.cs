using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankCharge.Models;
using BankCharge.Service;
using Microsoft.AspNetCore.Mvc;

namespace BankCharge.Controllers
{
    public class ChargeController : Controller
    {
        private readonly IBankService _bankService;
        private readonly IPatnerService _patnerService;
        public ChargeController( IBankService bankService,IPatnerService patnerService)
        {
            _patnerService = patnerService;
            _bankService = bankService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.BankList = _bankService.GetBanks();
            ViewBag.Patner = _patnerService.GetPatners();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Patner patner)
        {


            return View();

        }
    }
}