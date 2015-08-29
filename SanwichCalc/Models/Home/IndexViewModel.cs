using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SanwichCalc.Models.Home
{
    public class IndexViewModel
    {
        public SelectList Currencies { get; set; }
        public SelectList Sandwiches { get; set; }
    }
}