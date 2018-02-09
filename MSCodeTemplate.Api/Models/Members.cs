using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSCodeTemplate.Api.Models
{
    public partial class Member
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}