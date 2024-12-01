using App.Domain.Core.Company.Data;
using App.Domain.Core.Company.DTOs;
using App.Domain.Core.Company.Service;
using App.Infra.Repo.Ef.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Company
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyQureyRepo _companyQueryRepo;

        public CompanyService(ICompanyQureyRepo companyQueryRepo)
        {
            _companyQueryRepo = companyQueryRepo;
        }
        public async Task<Core.Company.Entities.Company> CreateCompany(Core.Company.Entities.Company input)
        {
            await _companyQueryRepo.InsertCompany(input);
            return input;
            
        }
    }
}
