using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBongDaSo.Services;

namespace WebBongDaSo.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaginationController : ControllerBase
    {
        private PaginationServices paginationServices = new PaginationServices();

        [HttpGet]
        public IActionResult GetTotalPage()
        {
            return Ok(paginationServices.GetTotalOfPage());
        }
    }
}
