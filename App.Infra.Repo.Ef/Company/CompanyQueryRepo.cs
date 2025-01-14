using App.Domain.Core.Company.Data;
using App.Domain.Core.Company.Entities;
using App.Infra.SqlServer.Ef.Dbctx;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repo.Ef.Company
{
    public class CompanyQueryRepo : ICompanyQureyRepo
    {
        private readonly AppDbContext _appDb;

        public CompanyQueryRepo(AppDbContext appDb)
        {
            _appDb = appDb;
        }

        public async Task<bool> CompanyDelete(int id)
        {
            var Company = _appDb.Companies.FirstOrDefault(x => x.CompanyId == id);
            if (Company != null)
            {
                _appDb.Companies.Remove(Company);
                await _appDb.SaveChangesAsync();
                return true;
            }
            return false;
            
        }


        public async Task<List<CompanyViewDTOs>> GetAllCompany()
        {
            return await _appDb.Companies.AsNoTracking().Select(x => new CompanyViewDTOs
            {
                CompanyName = x.CompanyName,
                PhoneNumber = x.PhoneNumber,
                Travels = x.Travels.ToList(),
            }).ToListAsync();
        }

        public async Task InsertCompany(Domain.Core.Company.Entities.Company company)
        {
            _appDb.Add(company);
            await _appDb.SaveChangesAsync();
        }


    }
}