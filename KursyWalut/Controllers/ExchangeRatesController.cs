using KursyWalut.Models;
using KursyWalut.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursyWalut.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRatesController : ControllerBase 
    {

        [HttpGet("/{targetExRate}/{startDate}/{endDate}")]
        public async Task<JsonResult> getInitDataAndroid( string targetExRate, string startDate, string endDate)
        {
            //if (ExchangeRateRepository.Get(baseExRate, targetExRate, startDate, endDate) == null)
            //{

            //}
            var resultString = await ApiConnector.InitializeClientAsync(targetExRate, startDate.ToString(), endDate.ToString());

            return new JsonResult(resultString);
        }

    }
}
