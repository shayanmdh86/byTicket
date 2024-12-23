﻿using App.Domain.Core.Company.AppService;
using App.Domain.Core.Company.DTOs;
using App.Domain.Core.Company.Service;
using App.Domain.Service.Company;

namespace App.Domain.AppService.Company
{
    public class CompanyAppService : ICompanyAppService
    {
        private readonly ICompanyService _companyService;
        public CompanyAppService(ICompanyService companyService)
        {
            _companyService = companyService;
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
    }
}
