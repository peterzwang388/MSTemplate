using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCodeTemplate.Api.Services.Interfaces
{
    public interface IDbContextFactory : IDisposable
    {
        ITemplateContext DbContext { get; }

    }
}
