using OpenQA.Selenium;
using SmokeMaker.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokeMaker.Entities
{
    public class WebInteration
    {
        public int InterationId { get; set; }
        public InterationType Type { get; set; }
        public IWebElement WebSiteElement { get; set; }


    }
}
