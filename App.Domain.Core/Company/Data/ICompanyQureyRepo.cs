using App.Domain.Core.Company.Entities;

namespace App.Domain.Core.Company.Data
{
    public interface ICompanyQureyRepo
    {
        Task InsertCompany(Company.Entities.Company company);
        Task<List<CompanyViewDTOs>> GetAllCompany();
        Task<Company.Entities.Company> CompanyGetById(int id);
        Task<bool> DeleteCompany(int id);
    }
}
