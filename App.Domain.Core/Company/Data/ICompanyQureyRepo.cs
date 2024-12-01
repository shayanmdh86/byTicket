using App.Domain.Core.Company.DTOs;
using App.Domain.Core.Company.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Company.Data
{
    public interface ICompanyQureyRepo
    {
        Task InsertCompany(Company.Entities.Company company);
    }
}
