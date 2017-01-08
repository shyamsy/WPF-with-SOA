using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Frontend.UIModels
{
    public class CountryInformationModel
    {
        public int CountryId { get; set; }

        public string Iso { get; set; }

        public string Name { get; set; }

        public string CommonName { get; set; }

        public string Iso3 { get; set; }

        public int NumCode { get; set; }

        public int Phonecode { get; set; }
    }
}
