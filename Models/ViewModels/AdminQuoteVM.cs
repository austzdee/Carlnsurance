using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carlnsurance.Models.ViewModels
{
    public class AdminQuoteVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public double Quote { get; set; }
    }
}