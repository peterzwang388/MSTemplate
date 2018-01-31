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
    }
}