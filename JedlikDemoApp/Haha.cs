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
                Context = "Jedlik 聲yos mondja az anyj嫕ak:",
                Conversation = new List<object> {
                    new
                    {
                        Person = "Jedlik 聲yos",
                        Message = "Mama, feltal嫮tam a dinam鏒!"
                    },
                    new
                    {
                        Person = "Jedlik 聲yos anyuk奫a",
                        Message = "Tudom 聲yos."
                    }
                }
            };

            return new OkObjectResult(joke);
        }
    }
}
