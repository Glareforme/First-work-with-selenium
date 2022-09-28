using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewModelTestFireFox.Support.DataForTests.Registration
{
    public static class CompanyAndUrl
    {
        public static string GenerateCompanyName()
        {
            string companyName = "Magadala";//hardcode
            return companyName;
        }
        public static string GenerateUrl(string companyName)
        {
            string companyUrl = "http://" + companyName + ".com";
            return companyUrl;
        }
    }
}
