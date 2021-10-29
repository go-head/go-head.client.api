using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace go_head.client.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        public IEnumerable<string> Get()
        {
            return new List<string>
            {
                "Jaba",
                "Onofre",
                "Vivi",
            };
        }
    }
}