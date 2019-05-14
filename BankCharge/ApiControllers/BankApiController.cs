using BankCharge.Models;
using BankCharge.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace BankCharge.ApiControllers
{
    public class BankApiController : Controller
    {
        private readonly IBankService _bankService;
        private readonly IPatnerService _patnerService;
        public BankApiController(IPatnerService patnerService, IBankService bankService)
        {
            _bankService = bankService;
            _patnerService = patnerService;
        }
        [Route("api/GetBank")]
        [HttpGet]
        public dynamic GetBank()
        {
            try
            {
                var data = _bankService.GetBanks();
                foreach (var item in data)
                {
                    item.Image = "/Image/" + item.Image;

                }
                return HttpResponse(StatusCodes.Status200OK, "Bank List", data);
            }
            catch (Exception e)
            {

                return ErrorResponse(StatusCodes.Status500InternalServerError, e.Message);
            }
           
          //  return StatusCode(StatusCodes.Status200OK,bank);
        }

        public object ErrorResponse(int statusCode, string msg)
        {

            return new
            {
                Code = statusCode,
                Message = msg,
                Errors = new string[] { msg }
            };
        }
        public object ErrorResponse(string msg)
        {
            return new
            {
                Code = (int)HttpStatusCode.BadRequest,
                Message = msg,
                Errors = new string[] { msg }
            };
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