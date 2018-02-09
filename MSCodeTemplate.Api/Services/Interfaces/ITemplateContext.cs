using MSCodeTemplate.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCodeTemplate.Api.Services.Interfaces
{
    public interface ITemplateContext : IDisposable
    {
        DbSet<Member> Members { get; set; }

        Task<int> SaveChangesAsync();
    }
}
