using App.Domain.Core.Company.Data;
using App.Domain.Core.Company.DTOs;
using App.Domain.Core.Company.Entities;
using App.Domain.Core.Company.Service;
using App.Infra.Repo.Ef.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App.Domain.Service.Company
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyQureyRepo _companyQueryRepo;

        public CompanyService(ICompanyQureyRepo companyQueryRepo)
        {
            _companyQueryRepo = companyQueryRepo;
        }
        public async Task<Core.Company.Entities.Company> CreateCompany(Core.Company.Entities.Company input)
        {
            await _companyQueryRepo.InsertCompany(input);
            return input;
        }

        


        private static readonly string pattern = @"^0\d{2,3}-?\d{7,8}$";

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, pattern);
        }

        public async Task<List<CompanyViewDTOs>> GetAllCompany()
        {
            return await _companyQueryRepo.GetAllCompany();
        }

        public async Task<bool> DeleteCompany(int id)
        {
            return await _companyQueryRepo.CompanyDelete(id);

        }
    }




    
}