using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private static readonly IHttpClientFactory _clientFactory;

        private IConfiguration _config;

        public CustomerController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        public async Task<ActionResult<String>> RegisterCustomer()  
        {
            //var request = new HttpRequestMessage(HttpMethod.Get, "https://api.lingaros.com/v1/lingapos/");

            //var client = _clientFactory.CreateClient();

            //HttpResponseMessage response = await client.SendAsync(request);

            //if (response.IsSuccessStatusCode)
            //{
            //     return customer = await response.Content.ReadFromJsonAsync<Customer>();
            //}
            //else
            //{
            //    return null;
            //}

            // alternative post method

            var client = _clientFactory.CreateClient("meta");

            try
            {
                return client.BaseAddress.ToString();
            }
            catch(Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

    }
}
