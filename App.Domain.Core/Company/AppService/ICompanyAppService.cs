using App.Domain.Core.Company.DTOs;
using App.Domain.Core.Company.Entities;
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
        Task<bool> UpdateCompany(int id,CompanyUpdateDto input);
        Task<CompanyViewDTOs> GetAllCompany();



    }
}
