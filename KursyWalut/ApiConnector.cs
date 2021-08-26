using KursyWalut.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace KursyWalut
{
    public static class ApiConnector
    {

        public static HttpClient ApiClient { get; set; }

        public static async Task<Root> InitializeClientAsync(string targetExRate, string startDate, string endDate)
        {

            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Root exchangeRate = null;
            try
            {
                //HttpResponseMessage response = await ApiClient.GetAsync("http://api.nbp.pl/api/exchangerates/rates/a/" + targetExRate + "/" + startDate + "/" + endDate + "/");
                HttpResponseMessage response = await ApiClient.GetAsync("https://sdw-wsrest.ecb.europa.eu/service/data/EXR/D.USD.EUR.SP00.A?startPeriod=2009-05-01&endPeriod=2009-05-31");

                if (response.IsSuccessStatusCode)
                {

                    var responseString = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseString))
                    {
                        exchangeRate = JsonConvert.DeserializeObject<Root>(responseString);

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return exchangeRate;
        }
    }
}
