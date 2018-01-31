using MSCodeTemplate.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MSCodeTemplate.Api.Services
{
    public class TemplateService : ServiceBase, ITemplateService
    {
        public TemplateService(IDbContextFactory dbContextFactory)
            : base(dbContextFactory)
        {
            
        }

        public async Task<dynamic> GetTest(string request)
        {
            return "Get Test OK";
        }

    }
}