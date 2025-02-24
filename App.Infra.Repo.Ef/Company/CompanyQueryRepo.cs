﻿using App.Domain.Core.Company.Data;
using App.Domain.Core.Company.DTOs;
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
            try
            {
                var entity = _appDb.Companies.FirstOrDefault(x => x.CompanyId == id);
                if (entity != null)
                {
                    _appDb.Companies.Remove(entity);
                    await _appDb.SaveChangesAsync();
                    return true;
                }
                return false;
                //throw new NullReferenceException();
            }
            catch (Exception ex)
            {
                // Replace this with your logging mechanism
                Console.WriteLine("Error deleting company: ", ex.Message,ex.Data);
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
                entity.TravelId=entity.TravelId;
                entity.Travels=entity.Travels;
                
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