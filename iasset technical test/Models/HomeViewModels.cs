using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iasset_technical_test.Models
{
    public class HomeViewModels
    {
        public string Country { get; set; }
        public IEnumerable<SelectListItem> Cities { get; set; }
        public int Selected { get; set; }
    }
}