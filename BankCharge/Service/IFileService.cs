using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankCharge.Service
{
    public interface IFileService
    {
        string SavaImage(IFormFile formFile);
    }
}