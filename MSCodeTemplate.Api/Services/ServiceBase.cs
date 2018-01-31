using MSCodeTemplate.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSCodeTemplate.Api.Services
{
    public abstract class ServiceBase : IDisposable
    {
        private readonly IDbContextFactory _dbContextFactory;
        
        protected ITemplateContext DbContext { get { return _dbContextFactory.DbContext; } }

        public ServiceBase(IDbContextFactory dbContextFactory)
        {
            if (dbContextFactory == null)
                throw new ArgumentNullException("dbContextFactory");

            this._dbContextFactory = dbContextFactory;
        }


        public void Dispose()
        {
            this._dbContextFactory.Dispose();
        }
    }
}