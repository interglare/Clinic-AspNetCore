using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2
{
    public class Program
    {
        protected static Timer timer;

        protected void Application_Start(Object sender, EventArgs e)
        {
            timer = new Timer(PatientToCall, null, TimeSpan.FromHours(2), TimeSpan.FromHours(2));
        }

        protected async void PatientToCall(Object state)
        {
            using (var client = new HttpClient())
            {
                string url = string.Format("");
                var response = client.GetAsync(url).Result;

                string responseAsString = await response.Content.ReadAsStringAsync();
                var resultResult = JsonConvert.DeserializeObject<Patient>(responseAsString);
                var httpClient = new HttpClient();
                var patientUrl = "https://localhost:44307/api/patients";

            }
        }
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
