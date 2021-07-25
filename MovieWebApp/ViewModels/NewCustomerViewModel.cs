using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieWebApp.Models;

namespace MovieWebApp.ViewModels
{
    public class NewCustomerViewModel
    {
        public Customer Customer { get; set; }

        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}