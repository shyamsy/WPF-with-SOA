using CAClient.Business.Layer.CAUtils;
using CAClient.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAClient.Service.CAUtils
{
    public class CountryDetails : ICountryDetails
    {
        public List<CountryModel> GetCountryData()
        {
            var countryDetails = new CountryDetail();
            var countryData = countryDetails.GetCountryData();
            return countryData;
        }
    }
}