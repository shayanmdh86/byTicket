using App.Domain.Core.Company.AppService;
using App.Domain.Core.Company.DTOs;
using App.Domain.Core.Company.Entities;
using App.Domain.Core.Company.Service;

namespace App.Domain.AppService.Company
{
    public class CompanyAppService : ICompanyAppService
    {
        private readonly ICompanyService _companyService;
        public CompanyAppService(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        //public async Task<List<CompanyViewDTOs>> CompanyShowList()
        //{
        //    return await _companyService.GetAllCompany();
        //}

      

        public async Task<bool> DeleteCompany(int id)
        {
           return await _companyService.DeleteCompany(id);

        }

        
      

        public Task<UpdateCompanyResponseDto> UpdateCompany(int id, CompanyUpdateDto updateDto)
        {

            _companyService.UpdateCompany(id, updateDto);
            throw new NotImplementedException();
        }

    

        public async Task<List<CompanyViewDTOs>> GetCompanyView(int id)
        {
            return await _companyService.CompanyViews();
        }

        public async Task<Core.Company.Entities.Company> CreateCompany(CompanyInputDto input)
        {
            Core.Company.Entities.Company Company = new Core.Company.Entities.Company
            {

                CompanyName = input.CompanyName,
                PhoneNumber = input.PhoneNumber,
            };
           await _companyService.CreateCompany(Company);
            return Company;
        }

        Task<bool> ICompanyAppService.UpdateCompany(int id, CompanyUpdateDto input)
        {
            throw new NotImplementedException();
        }
    }
}
