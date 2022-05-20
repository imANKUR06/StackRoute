using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Controllers
{
    
    [ApiController]
    public class ErrorController : ControllerBase
    {

        [Route("Error")]
        public IActionResult Error()
        {
            var ExceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var exceptionPath = ExceptionHandlerFeature.Path;
            var exceptionMessage = ExceptionHandlerFeature.Error.Message;
            var exceptionDetails = ExceptionHandlerFeature.Error.StackTrace;

            // Logic code for logging the above exception details.


            return StatusCode(500, new { Error = "Something went wrong!!! Please contact admin." });



        }
    }
}
