using MSCodeTemplate.Api.Models;
using MSCodeTemplate.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using System.Data.Entity;


namespace MSCodeTemplate.Api.Services
{
    public class TemplateService : ServiceBase, ITemplateService
    {
        public TemplateService(IDbContextFactory dbContextFactory)
            : base(dbContextFactory)
        {
            int x = 1;
        }

        public async Task<dynamic> GetTest(string request)
        {
            return "GettestOK";
        }

        public async Task<dynamic> GetMemberName(string referenceNumber)
        {
            string name = "";
            Member result = await GetMember(referenceNumber);

            name = result.FirstName + " " + result.LastName;
            return name;

        }
        private async Task<Member> GetMember(string referenceNumber)
        {
            return await this.DbContext.Members.Where(x => String.Compare(x.ReferenceNumber, referenceNumber, true) == 0).AsNoTracking().FirstOrDefaultAsync();
        }



    }
}