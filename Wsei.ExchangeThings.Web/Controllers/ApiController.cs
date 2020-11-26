using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wsei.ExchangeThings.Web.Models;

namespace Wsei.ExchangeThings.Web.Controllers
{
    [ApiController]
    [Route("api/company")]
    public class ApiController : ControllerBase
    {
        public IActionResult Post(CompanyModel company)
        {
            try
            {
                CompanyAddedViewModel response = new CompanyAddedViewModel
                {
                    NumberOfCharsInName = company.Name.Length,
                    NumberOfCharsInDescription = company.Description.Length,
                    IsHidden = !company.IsVisible
                };

                return Ok(response);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }
 
    }
}
