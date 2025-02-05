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
        Task<Core.Company.Entities.Company> CreateCompany(DTOs.Company input);
        Task<List<CompanyViewDTOs>> CompanyShowList();
        Task<bool> DeleteCompany(int id);
        Task<UpdateCompanyResponseDto> UpdateCompany(int id,CompanyUpdateDto updateDto);
    }
}
