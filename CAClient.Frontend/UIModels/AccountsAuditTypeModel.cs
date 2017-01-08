using CAClient.Frontend.MvvmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Frontend.UIModels
{
    public class AccountsAuditTypeModel : ViewModelBase
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string accountsType;
        public string AccountsType
        {
            get { return accountsType; }
            set
            {
                accountsType = value;
                OnPropertyChanged("AccountsType");
            }
        }

        private string accountsTypeCode;
        public string AccountsTypeCode
        {
            get { return accountsTypeCode; }
            set
            {
                accountsTypeCode = value;
                OnPropertyChanged("AccountsTypeCode");
            }
        }

        private string limit;
        public string Limit
        {
            get { return limit; }
            set { limit = value;
            OnPropertyChanged("Limit");
            }
        }

        private DateTime lastUpdated;
        public DateTime LastUpdated
        {
            get { return lastUpdated; }
            set { lastUpdated = value;
            OnPropertyChanged("LastUpdated");
            }
        }
    }
}
