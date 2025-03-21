using App.Domain.Core.Company.DTOs;
using App.Domain.Core.Company.Entities;
using System.Data;

namespace App.Domain.Core.Company.Data
{
    public interface ICompanyQureyRepo
    {
        Task InsertCompany(Company.Entities.Company company);
        Task<List<CompanyViewDTOs>> GetAllCompany();
        Task<bool> CompanyDelete(int id);
        Task<bool> UpdateCom(int Id ,Company.DTOs.CompanyUpdateDto UpdateCompany);
        Task<Company.Entities.Company> GetCompanyById(int id);
    }
}
