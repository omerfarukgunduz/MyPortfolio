using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using Newtonsoft.Json;

namespace MyPortfolio.Controllers
{
    public class DenemeController : Controller
    {
      
            public async Task<Main> Index()
            {

            // sql bağlantı - sql sorgu veri çek, location değişkeni 
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://api.openweathermap.org/data/2.5/weather?q=Istanbul,tr&APPID=777f431539f27f4b13be297e56710393&units=metric"),
                  
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<WeatherViewModel>(body);

                return values.main;
                }
            }


        
    }
    }

 