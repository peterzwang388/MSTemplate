using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCodeTemplate.Api.Services.Interfaces
{
    public interface ITemplateService
    {

        Task<dynamic> GetTest(string request);
        Task<dynamic> GetMemberName(string request);
    }
}
