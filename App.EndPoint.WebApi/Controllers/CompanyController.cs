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

