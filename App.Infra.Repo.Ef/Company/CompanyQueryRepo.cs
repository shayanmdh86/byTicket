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

        public async Task<Domain.Core.Company.Entities.Company> CompanyGetById(int id)
        {
            try
            {
                var res = await _appDb.Companies.FirstOrDefaultAsync(x => x.CompanyId == id);
                return res;

            }
            catch (Exception ex)
            {


                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public async Task<bool> DeleteCompany(int id)
        {
            try
            {
                var Entity = await _appDb.Companies.FindAsync(id);

                if (Entity != null)
                {
                    _appDb.Companies.Remove(Entity);
                    await _appDb.SaveChangesAsync();
                    return true;

                }
                return false;

            }
            catch (Exception ex)
            {

               Console.WriteLine(ex.Message,",عملیات موفق امیز نبود!!");
                return false;
            }
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