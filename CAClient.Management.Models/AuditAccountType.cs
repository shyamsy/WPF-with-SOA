using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Management.Models
{
    [DataContract]
    public class AuditAccountType
    {
        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public string AccountTypeCode { get; set; }

        [DataMember]
        public string AccountType { get; set; }

        [DataMember]
        public string Limit { get; set; }

        [DataMember]
        public DateTime DateUpdated { get; set; }
    }
}
