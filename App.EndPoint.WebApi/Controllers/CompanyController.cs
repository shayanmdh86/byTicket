using App.Domain.Core.Company.AppService;
using App.Domain.Core.Company.DTOs;
using App.Domain.Core.Company.Service;
using App.Domain.Service.Company;
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
        //private readonly ICompanyService _companyService;

        public CompanyController(ICompanyAppService companyAppService)
        {
            _companyAppService = companyAppService;
            //_companyService = companyService;
        }

        [HttpPost]
        public async Task<IActionResult>PostCompany(CompanyInputDto companyInputDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!CompanyService.IsValidPhoneNumber(companyInputDto.PhoneNumber))
            {
                return BadRequest("Invalid Phone Number Is Format.");
            }

           await _companyAppService.CreateCompany(companyInputDto);
            return Ok(companyInputDto);

        }
    }
}
