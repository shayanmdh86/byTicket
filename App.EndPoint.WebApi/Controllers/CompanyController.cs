using App.Domain.Core.Company.AppService;
using App.Domain.Core.Company.DTOs;

using App.Domain.Service.Company;
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
        public async Task<IActionResult> PostCompany(CompanyInputDto companyInputDto)

        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!CompanyService.IsValidPhoneNumber(companyInputDto.PhoneNumber))
            {
                return BadRequest("Invalid Phone Number Is Format.");
            }

            var CreatedCom = await _companyAppService.CreateCompany(companyInputDto);
            return Ok(new
            {
                Message = "Company created successfully!",
                Com = CreatedCom.CompanyId
            });
        }

        [HttpDelete]
        public async Task<bool> CompanyDelete(int id)
        {
            int Numb;
            bool Isnumber= int.TryParse(id.ToString(), out Numb);
            if (Isnumber)
            {
                _companyAppService.DeleteCompany(id);
                return true;
            }
            return false;

            
           
           
        }


        [HttpPut]
        public async Task<ActionResult<UpdateCompanyResponseDto>> UpdateCompany(int id, CompanyUpdateDto updateDto)
        {
            if (id <= 0 || updateDto == null)
            {
                return BadRequest("Invalid Parameters.");

            }
            try
            {
                var Respons = await _companyAppService.UpdateCompany(id, updateDto);

                if (Respons == null)

                    return BadRequest(Respons);


                return Ok(Respons);

            }
            catch (Exception ex)
            {

                return StatusCode(500, "خطا در بروزرسانی شرکت!!!");
            }

            //[HttpDelete]
            // async Task<IActionResult> DeleteCompany(int id)
            //{
            //    if (id != 0 && ModelState.IsValid)
            //    {
            //        await _companyAppService.DeleteCompany(id);
            //        return Ok();
            //    }
            //    return BadRequest();


     
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCompany()
        {
            var entity = await _companyAppService.GetAllCompany();
            return Ok(entity);

        }
    }
}

