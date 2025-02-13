using App.Domain.Core.Company.AppService;
using App.Domain.Core.Company.DTOs;
using App.Domain.Core.Company.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Company.Service
{
    public interface ICompanyService
    {
        Task<Company.Entities.Company> CreateCompany(Core.Company.Entities.Company input);
        Task<bool> UpdateCompany(int id,CompanyUpdateDto updateDto);
        Task<List<CompanyViewDTOs>> CompanyViews();
        Task<bool> DeleteCompany(int id);  
    }
}
