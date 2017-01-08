using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Management.Models
{
    [DataContract]
    public class CountryModel
    {
        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        public string Iso { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CommonName { get; set; }

        [DataMember]
        public string Iso3 { get; set; }

        [DataMember]
        public int NumCode { get; set; }

        [DataMember]
        public int Phonecode { get; set; }
    }
}
