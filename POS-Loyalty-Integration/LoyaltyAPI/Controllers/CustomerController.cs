using API.Models;
using LoyaltyAPI.Helpers;
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
        private static readonly HttpClient client = new HttpClient();

        private IConfiguration _config;

        public CustomerController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> RegisterCustomer(Customer customer)
        {

            using (HttpResponseMessage response = await ApiHelper.Client.PostAsync<Customer>("customer", customer, new MediaTypeFormatter("application/json")))
            {

            }
        }

    }
}
