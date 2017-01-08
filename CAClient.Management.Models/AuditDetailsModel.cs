using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Management.Models
{
    [DataContract]
    public class AuditDetailsModel
    {

        [DataMember]
        public int AuditId { get; set; }

        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public int AccountTypeId { get; set; }

        [DataMember]
        public int TurnoverTypeId { get; set; }

        [DataMember]
        public string ProfRecNumber { get; set; }

        [DataMember]
        public bool AuditRequired { get; set; }


        [DataMember]
        public int ProfReceiptMoney { get; set; }


        [DataMember]
        public int TuronOverMoney { get; set; }


        [DataMember]
        public DateTime AuditStartDate { get; set; }


        [DataMember]
        public DateTime AuditEndDate { get; set; }


        [DataMember]
        public int AuditBy { get; set; }


        [DataMember]
        public double AuditFee { get; set; }

    }
}
