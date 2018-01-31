using MSCodeTemplate.Api.Models;
using MSCodeTemplate.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSCodeTemplate.Api.Services
{
    public class DbContextFactory : IDbContextFactory
    {

        private ITemplateContext templateContext;

        public ITemplateContext DbContext
        {
            get
            {
                if (templateContext == null)
                {
                    templateContext = new TemplateContext();
                }

                return templateContext;
            }
        }

        public void Dispose()
        {
            if (templateContext != null)
            {
                templateContext.Dispose();
            }
        }
    }
}