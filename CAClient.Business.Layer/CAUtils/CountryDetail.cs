using CAClient.DataAccess.Layer.CAUtils;
using CAClient.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Business.Layer.CAUtils
{
    public class CountryDetail
    {
        public List<CountryModel> GetCountryData()
        {
            var countryDetail = new CountryDetails();
            var countryData = countryDetail.GetCountryData();
            return countryData;
        }
    }
}
