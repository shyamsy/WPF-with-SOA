using CAClient.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Service.CAUtils
{
    [ServiceContract]
    public interface ICountryDetails
    {
        [OperationContract]
        List<CountryModel> GetCountryData();
    }
}
