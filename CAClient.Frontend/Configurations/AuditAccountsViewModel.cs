using CAClient.Frontend.MvvmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CAClient.Frontend.UIModels;
using System.Windows.Input;

namespace CAClient.Frontend.Configurations
{
    public class AuditAccountsViewModel : ViewModelBase
    {

        public AuditAccountsViewModel()
        {
            AccountType = new AccountsAuditTypeModel();
            ShowAccountTypes();
        }

        private AccountsAuditTypeModel accountType;
        public AccountsAuditTypeModel AccountType
        {
            get { return accountType; }
            set
            {
                accountType = value;
                OnPropertyChanged("AccountType");
            }
        }

        private ObservableCollection<AccountsAuditTypeModel> audtAccountTypes;
        public ObservableCollection<AccountsAuditTypeModel> AudtAccountTypes
        {
            get { return audtAccountTypes; }
            set
            {
                audtAccountTypes = value;
                OnPropertyChanged("AudtAccountTypes");
            }
        }

        public ICommand SaveAccountTypeCommand
        {
            get { return new RelayCommand(SaveAccountType, CanSaveAccountType); }
        }

        private bool CanSaveAccountType()
        {
            return true;
        }

        private void SaveAccountType()
        {
            AuditDetailsClient auditClient = new AuditDetailsClient();
            CAClient.Management.Models.AuditAccountType accountType = new CAClient.Management.Models.AuditAccountType();
            accountType.AccountType = AccountType.AccountsType;
            accountType.AccountTypeCode = AccountType.AccountsTypeCode;
            accountType.Limit = AccountType.Limit;
            auditClient.AddAuditAccountType(accountType);
            ShowAccountTypes();
        }

        private void ShowAccountTypes()
        {
            AuditDetailsClient auditClient = new AuditDetailsClient();
            var accountTypesData = auditClient.GetAccountsTypeData();
            AudtAccountTypes = new ObservableCollection<AccountsAuditTypeModel>();
            foreach (var accountType in accountTypesData)
            {
                AccountsAuditTypeModel accountData = new AccountsAuditTypeModel();
                accountData.Id = accountType.AccountId;
                accountData.AccountsTypeCode = accountType.AccountTypeCode;
                accountData.AccountsType = accountType.AccountType;
                accountData.Limit = accountType.Limit;
                accountData.LastUpdated = accountType.DateUpdated;
                AudtAccountTypes.Add(accountData);
            }
        }
    }
}
