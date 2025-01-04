using App.Domain.Core.Company.Data;
using App.Domain.Core.Company.DTOs;
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

        private static readonly Dictionary<string, string> CityCodes = new Dictionary<string, string> { { "021", "Tehran" },
                { "031", "Isfahan" },
                { "071", "Shiraz" },
                { "051", "Mashhad" },
                { "041", "Tabriz" },
                { "035", "Yazd" }
        };


        private static readonly string pattern = @"^0\d{2,3}-?\d{7,8}$";

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }




    
}