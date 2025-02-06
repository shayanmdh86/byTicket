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
        private readonly ICompanyQureyRepo _companyQureyRepo;

        

        public CompanyController(ICompanyAppService companyAppService,ICompanyQureyRepo companyQureyRepo)
        {
            _companyAppService = companyAppService;
            _companyQureyRepo = companyQureyRepo;
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

        [HttpGet]
        public async Task<List<CompanyViewDTOs>> GetCompanies()
        {
           return await _companyQureyRepo.GetAllCompany();

        }

        
        //public async Task<ActionResult<UpdateCompanyResponseDto>> UpdateCompany(int id, CompanyUpdateDto updateDto)
        //{
        //    if (id <= 0 || updateDto == null)
        //    {
        //        return BadRequest("Invalid Parameters.");

        //    }
        //    try
        //    {
        //        var Respons = await _companyQureyRepo.UpdateCom(id,updateDto);

        //        if (Respons == null)

        //            return BadRequest(Respons);


        //        return Ok(Respons);

        //    }
        //    catch (Exception ex)
        //    {

        //        return StatusCode(500, "خطا در بروزرسانی شرکت!!!");
        //    }

        //}
    }
}

