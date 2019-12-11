using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace MyFunctionProj
{
    public static class MyHttpTrigger
    {
        [FunctionName("Ok")]
        public static async Task<IActionResult> Ok(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            string message = "Ok request...";
            log.LogInformation(message);
            return new OkObjectResult(message);
        }
    }
}
