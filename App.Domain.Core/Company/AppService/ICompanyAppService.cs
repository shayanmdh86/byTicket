using App.Domain.Core.Company.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Company.AppService
{
    public interface ICompanyAppService
    {
        Task<Core.Company.Entities.Company> CreateCompany(CompanyInputDto input);
        Task<bool> DeleteCompany(int id);
        Task<List<CompanyViewDTOs>> GetCompanyView(int id);
        Task<List<CompanyViewDTOs>> GetCompanies();

    }
}
