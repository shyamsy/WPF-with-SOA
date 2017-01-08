using CAClient.Frontend.MvvmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Frontend.UIModels
{
    public class AuditModel : ViewModelBase
    {

        private int auditId;
        public int AuditId
        {
            get { return auditId; }
            set
            {
                auditId = value;
                OnPropertyChanged("AuditId");
            }
        }

        private int clientId;
        public int ClientId
        {
            get { return clientId; }
            set
            {
                clientId = value;
                OnPropertyChanged("ClientId");
            }
        }

        private bool auditRequired;
        public bool AuditRequired
        {
            get { return auditRequired; }
            set
            {
                auditRequired = value;
                OnPropertyChanged("AuditRequired");
            }
        }

        private int profReceiptMoney;
        public int ProfReceiptMoney
        {
            get { return profReceiptMoney; }
            set
            {
                profReceiptMoney = value;
                OnPropertyChanged("ProfReceiptMoney");
            }
        }

        private int turonOverMoney;
        public int TuronOverMoney
        {
            get { return turonOverMoney; }
            set
            {
                turonOverMoney = value;
                OnPropertyChanged("TuronOverMoney");
            }
        }

        private DateTime auditStartDate;
        public DateTime AuditStartDate
        {
            get { return auditStartDate; }
            set
            {
                auditStartDate = value;
                OnPropertyChanged("AuditStartDate");
            }
        }

        private DateTime auditEndDate;
        public DateTime AuditEndDate
        {
            get { return auditEndDate; }
            set
            {
                auditEndDate = value;
                OnPropertyChanged("AuditEndDate");
            }
        }

        private string auditBy;
        public string AuditBy
        {
            get { return auditBy; }
            set
            {
                auditBy = value;
                OnPropertyChanged("AuditBy");
            }
        }

        private double auditFee;
        public double AuditFee
        {
            get { return auditFee; }
            set
            {
                auditFee = value;
                OnPropertyChanged("AuditFee");
            }
        }
    }
}
