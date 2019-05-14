using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankCharge.Models;
using BankCharge.Service;
using Microsoft.AspNetCore.Mvc;

namespace BankCharge.Controllers
{
    public class PatnerController : Controller
    {
        private readonly IBankService _bankService;
        private readonly IPatnerService _patnerService;
        public PatnerController(IPatnerService patnerService, IBankService bankService)
        {
            _bankService = bankService;
            _patnerService = patnerService;
        }

        public IActionResult Index()
        {
            var bank = _bankService.GetBanks();
            List<PatnerViewModel> patnerViewModel = new List<PatnerViewModel>();
            foreach (var item in bank)
            {
                var parterbank = _patnerService.GetPatnerById(item.BankId);
                PatnerViewModel list = new PatnerViewModel();
                if (parterbank!=null)
                {
                    string[] values = parterbank.PatnerId.Split(',').Select(sValue => sValue.Trim()).ToArray();
                    List<Bank> banklist = new List<Bank>();
                    foreach (var partrbank in values)
                    {
                        var data = _bankService.GetBankById(Convert.ToInt32(partrbank));
                        banklist.Add(data);
                    }
                    list.Bank = item;
                    list.PatnerBank = banklist;
                    patnerViewModel.Add(list);
                }
                else
                {
                    list.Bank = item;
                   // list.PatnerBank = banklist;
                    patnerViewModel.Add(list);
                }
            }
            return View(patnerViewModel);
        }
        [HttpGet]
        public IActionResult New()
        {


            ViewBag.Bank = _bankService.GetBanks();
            return View();
        }

        [HttpPost]
        public JsonResult New(List<Patner> patners)
        {
            try

            {
                foreach (var item in patners)
                {
                    _patnerService.New(item);
                }
                return Json(patners);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}