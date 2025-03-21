using App.Domain.Core.Company.Data;
using App.Domain.Core.Company.DTOs;
using App.Infra.SqlServer.Ef.Dbctx;
using Microsoft.EntityFrameworkCore;
using System.Net;

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
            try
            {

                var Entity = _appDb.Companies.FirstOrDefault(x => x.CompanyId == id);
                if (Entity != null)
                {
                    _appDb.Companies.Remove(Entity);
                    _appDb.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {

                Console.WriteLine("عملیات حذف با خطا مواجه شد",ex.ToString());
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

        public async Task<Domain.Core.Company.Entities.Company> GetCompanyById(int id)
        {
            return await _appDb.Companies.FirstOrDefaultAsync(x => x.CompanyId == id);

        }

        public async Task InsertCompany(Domain.Core.Company.Entities.Company company)
        {
            _appDb.Add(company);
            await _appDb.SaveChangesAsync();
        }

        public async Task<bool> UpdateCom(int Id, CompanyUpdateDto UpdateCompany)
        {
            var entity = await GetCompanyById(Id);
            if (entity != null)
            {
                entity.CompanyId = Id;
                entity.CompanyName = UpdateCompany.CompanyName;
                entity.PhoneNumber = UpdateCompany.PhoneNumber;
                entity.TravelId = entity.TravelId;
                entity.Travels = entity.Travels;

                await _appDb.SaveChangesAsync();


                return true;
            }
            else
            {
                return false;
            }
        }



    }
}