using CAClient.DataAccess.Layer.DALUtils;
using CAClient.Management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.DataAccess.Layer.CAUtils
{
    public class CountryDetails
    {
        public List<CountryModel> GetCountryData()
        {
            List<CountryModel> countryData = new List<CountryModel>();

            try
            {
                var database = SingletonDb.Instance.GetDBConnection();
                object[] parameterValues = new object[] { 1 };
                DbCommand cmd = database.GetStoredProcCommand("dbo.Country_Select_sp", parameterValues);

                using (IDataReader reader = database.ExecuteReader(cmd))
                {
                    while (reader.Read())
                    {
                        CountryModel countryModel = new CountryModel();
                        countryModel.CountryId = !reader.IsDBNull(reader.GetOrdinal("inCountryId")) ? reader.GetInt32(0) : -1;
                        countryModel.Iso = !reader.IsDBNull(reader.GetOrdinal("vcCountryISO")) ? reader.GetString(1) : string.Empty;
                        countryModel.Name = !reader.IsDBNull(reader.GetOrdinal("vcCountryName")) ? reader.GetString(2) : string.Empty;
                        countryModel.CommonName = !reader.IsDBNull(reader.GetOrdinal("vcCountryCommonName")) ? reader.GetString(3) : string.Empty;
                        countryModel.Iso3 = !reader.IsDBNull(reader.GetOrdinal("vcCountryISO3")) ? reader.GetString(4) : string.Empty;
                        countryModel.NumCode = !reader.IsDBNull(reader.GetOrdinal("inCountryNumCode")) ? reader.GetInt32(5) : -1;
                        countryModel.Phonecode = !reader.IsDBNull(reader.GetOrdinal("inCountryPhoneCode")) ? reader.GetInt32(6) : -1;
                        countryData.Add(countryModel);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return countryData;
        }
    }
}
