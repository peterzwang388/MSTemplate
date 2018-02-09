using MSCodeTemplate.Api.Models.Mappings;
using MSCodeTemplate.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MSCodeTemplate.Api.Models
{
    public class TemplateContext : DbContext, ITemplateContext
    {
        public DbSet<Member> Members { get; set; }

        static TemplateContext()
        {
            Database.SetInitializer<TemplateContext>(null);
        }



        public TemplateContext()
            : base("Name=TemplateContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
        }

    }
}