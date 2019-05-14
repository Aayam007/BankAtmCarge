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
    
    public class PatnerApiController : ControllerBase
    {
        private readonly IBankService _bankService;
        private readonly IPatnerService _patnerService;
        public PatnerApiController(IPatnerService patnerService, IBankService bankService)
        {
            _bankService = bankService;
            _patnerService = patnerService;
        }
        [Route("api/GetPatner")]
        public dynamic GetPatner()
        {
            var bank = _bankService.GetBanks();
            List<PatnerViewModel> patnerViewModel = new List<PatnerViewModel>();
            foreach (var item in bank)
            {
                item.Image = "/Image/" + item.Image;
                var parterbank = _patnerService.GetPatnerById(item.BankId);
                PatnerViewModel list = new PatnerViewModel();
                if (parterbank != null)
                {
                    string[] values = parterbank.PatnerId.Split(',').Select(sValue => sValue.Trim()).ToArray();
                    List<Bank> banklist = new List<Bank>();
                    foreach (var partrbank in values)
                    {
                        
                        var data = _bankService.GetBankById(Convert.ToInt32(partrbank));
                        if(data!= null)
                        {
                            data.Image = "/Image/" + data.Image;
                        }
                        
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
            return HttpResponse(StatusCodes.Status200OK, "Bank With PatnerList", patnerViewModel);
        }
        public object HttpResponse(int statusCode, string msg, object data)
        {

            return new
            {
                Code = statusCode,
                Message = msg,
                Data = data
            };
        }
    }
}