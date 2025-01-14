using App.Domain.Core.Company.AppService;
using App.Domain.Core.Company.Data;
using App.Domain.Core.Company.DTOs;
using App.Domain.Core.Company.Entities;
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

        public CompanyController(ICompanyAppService companyAppService)
        {
            _companyAppService = companyAppService;
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

            var CreatedCom=  await _companyAppService.CreateCompany(companyInputDto);
            return Ok(new { Message = "Company created successfully!",
                Com = CreatedCom.CompanyId
            });
        }

        [HttpDelete]
        public async Task<bool> CompanyDelete([FromQuery] int id)
        {
            return await _companyAppService.DeleteCompany(id); 
        }

        [HttpGet]
        public async Task<List<CompanyViewDTOs>> ShowAllCompany()
        {
            return await _companyAppService.CompanyShowList();
          
        }
    }
}

