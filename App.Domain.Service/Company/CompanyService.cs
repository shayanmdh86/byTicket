﻿using App.Domain.Core.Company.Data;
using App.Domain.Core.Company.Service;
using System.Text.RegularExpressions;

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

        public async Task<bool> DeleteCompany(int id)
        {
            return await _companyQueryRepo.DeleteCompany(id);
        }

        public async Task<List<CompanyViewDTOs>> CompanyViews()
        {
            return await _companyQueryRepo.GetAllCompany();

        }
    }





}