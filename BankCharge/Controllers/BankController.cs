using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankCharge.Models;
using BankCharge.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BankCharge.Controllers
{
    
    [Authorize]
    [Route("[controller]/[action]")]
    public class BankController : Controller
    {
        private readonly IBankService _bankService;
       
        private readonly IFileService _fileService;
        private readonly IPatnerService _patnerService;

        //private IHostingEnvironment _env;
        public BankController(IBankService bankService, IFileService fileService, IPatnerService patnerService)
        {
            _bankService = bankService;
            _fileService = fileService;
            _patnerService = patnerService;
            //_env = env;
        }
        [HttpGet]
        public IActionResult Index(int id)
        {
            var bank = _bankService.GetBanks();
            foreach (var item in bank)
            {
                item.Image = "/Image/" + item.Image;
               
            }
            return View(bank);
        }

        [HttpGet]
        public IActionResult New()
        {


            ViewBag.BankName = _bankService.GetBanks();
            return View();
        }

        [HttpPost]
        public JsonResult New(List<Bank> banks)
        {
            try
            {
                foreach (var item in banks)
                {
                    
                    _fileService.SavaImage(item.ImageUrl);
                    item.Image = item.ImageUrl.FileName;
                  
                    
                    _bankService.New(item);

                }
                return Json(banks);
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        [HttpGet]
        public IActionResult EditBank([FromQuery]int id)
        {
          
            if (id == 0)
            {
                return NotFound();
            }
           
            Bank bank = _bankService.GetBankById(id);
            bank.Image = "/Image/" + bank.Image;
            if (bank == null)
                return NotFound();
            return View(bank);
        }

        [HttpPost]
        public IActionResult EditBank(Bank bank)
        {
            if (bank.BankId != bank.BankId)
                return NotFound();

            if (ModelState.IsValid)
            {
                if (bank.ImageUrl == null)
                {
                    bank.Image = default;
                }
                else
                {
                    _fileService.SavaImage(bank.ImageUrl);
                    bank.Image = bank.ImageUrl.FileName;
                }
                    _bankService.EditBank(bank);
                return RedirectToAction("Index");
            }
            return View(bank);
        }
        public IActionResult DeleteBank(int id)
        {
            Bank bank = _bankService.GetBankById(id);
            if (bank == null)
            {
                return NotFound();
            }

            return View(bank);
        }
        [HttpPost]
        public IActionResult DeleteBank(int BankId, Bank bank)
        {
            if (_bankService.DeleteBank(BankId) > 0)
            {
                return RedirectToAction("Index");
            }
            return View(bank);
        }

        [HttpPost]
        public JsonResult Search(string txtValue)
        {
            var bank = _bankService.GetBankSearch(txtValue);
            return Json(bank);
        }
    }
}