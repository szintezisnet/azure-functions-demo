using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace JedlikDemoApp
{
    public static class Haha
    {
        [FunctionName("Haha")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(
                AuthorizationLevel.Function, 
                "get", "post", 
                Route = "dinamo"
            )] HttpRequest req)
        {
            var joke = new
            {
                Context = "Jedlik �nyos mondja az anyj�nak:",
                Conversation = new List<object> {
                    new
                    {
                        Person = "Jedlik �nyos",
                        Message = "Mama, feltal�ltam a dinam�t!"
                    },
                    new
                    {
                        Person = "Jedlik �nyos anyuk�ja",
                        Message = "Tudom �nyos."
                    }
                }
            };

            return new OkObjectResult(joke);
        }
    }
}
