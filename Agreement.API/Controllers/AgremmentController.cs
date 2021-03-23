using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agreement.Logic.BL;
using Agreement.Logic.Models;

namespace Agreement.API.Controllers
{
    [ApiController]
    public class AgremmentController : Controller
    {
        [HttpGet]
        [Route("api/Get")]
        public async Task<List<dtoAgreement>> Get()
        {
            Agreements agreements = new Agreements();
            return await agreements.GetAgreement();
        }
    }
}
