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

        private readonly IHttpClientFactory _clientFactory;

        public CustomerController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetCustomer(string customerId)
        {

            var client = _clientFactory.CreateClient("meta");

            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.lingaros.com/v1/lingapos/customer/" + customerId);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
