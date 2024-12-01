using App.Domain.Core.Company.AppService;
using App.Domain.Core.Company.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyAppService _companyAppService;

        public CompanyController(ICompanyAppService companyAppService)
        {
            _companyAppService = companyAppService;
        }

        [HttpPost]
        public async Task<IActionResult>PostCompany(CompanyInputDto companyInputDto)
        {
           await _companyAppService.CreateCompany(companyInputDto);
          return Ok(companyInputDto);

        }
    }
}
