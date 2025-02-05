using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Company.DTOs
{
    public class UpdateCompanyResponseDto
    {
        public bool IsSuccess {  get; set; }
        public string Message { get; set; }
        public Company? Company {  get; set; }

    }
}
