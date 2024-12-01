﻿using App.Domain.Core.Company.Data;
using App.Infra.SqlServer.Ef.Dbctx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Repo.Ef.Company
{
    public class CompanyQueryRepo : ICompanyQureyRepo
    {
        private readonly AppDbContext _appDb;

        public CompanyQueryRepo(AppDbContext appDb)
        {
            _appDb = appDb;
        }

        public async Task InsertCompany(Domain.Core.Company.Entities.Company company)
        {
            _appDb.Add(company);
            await _appDb.SaveChangesAsync();
        }
    }
}
