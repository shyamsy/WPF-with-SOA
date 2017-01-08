using CAClient.Frontend.MvvmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CAClient.Frontend.UIModels;
using System.Windows.Input;

namespace CAClient.Frontend.Audit
{
    public class NewAuditViewModel : ViewModelBase
    {
        private AuditModel auditModel;
        public AuditModel AuditModel
        {
            get { return auditModel; }
            set
            {
                auditModel = value;
                OnPropertyChanged("AuditModel");
            }
        }

        private string newAuditTitle;
        public string NewAuditTitle
        {
            get { return newAuditTitle; }
            set
            {
                newAuditTitle = value;
                OnPropertyChanged("NewAuditTitle");

            }
        }

        public NewAuditViewModel()
        {
            AuditModel = new AuditModel();
            ShowAccountTypes();
            ShowTurnoverypes();
        }

        private ObservableCollection<ClientInformationModel> clientDetail;
        public ObservableCollection<ClientInformationModel> ClientDetail
        {
            get { return clientDetail; }
            set
            {
                clientDetail = value;
                OnPropertyChanged("ClientDetail");
            }
        }

        private ObservableCollection<AccountsAuditTypeModel> accountsTypes;
        public ObservableCollection<AccountsAuditTypeModel> AccountsTypes
        {
            get { return accountsTypes; }
            set { accountsTypes = value; }
        }

        private ObservableCollection<TurnoverModel> turnoverTypes;
        public ObservableCollection<TurnoverModel> TurnoverTypes
        {
            get { return turnoverTypes; }
            set { turnoverTypes = value; }
        }

        public ICommand SearchClientCommand
        {
            get { return new RelayCommand(SearchClient, CanSearchClient); }
        }

        private bool CanSearchClient()
        {
            return true;
        }

        private void SearchClient()
        {
            GetClientInfoDetails();
        }

        public void GetClientInfoDetails()
        {
            ClientDetailsClient client = new ClientDetailsClient();
            var clientInfo = client.GetSingeClientData(AuditModel.ClientId);
            ClientDetail = new ObservableCollection<ClientInformationModel>();
            ClientInformationModel clientInfoModel = new ClientInformationModel();
            clientInfoModel.ClientId = clientInfo.ClientId;
            clientInfoModel.FirstName = clientInfo.FirstName;
            clientInfoModel.MiddleName = clientInfo.MiddleName;
            clientInfoModel.LastName = clientInfo.LastName;
            clientInfoModel.Address = clientInfo.Address;
            clientInfoModel.City = clientInfo.City;
            clientInfoModel.Country = clientInfo.Country;
            clientInfoModel.PinCode = clientInfo.PinCode;
            clientInfoModel.PhoneNumber = clientInfo.PhoneNumber;
            clientInfoModel.LastUpdated = clientInfo.LastUpdated;
            ClientDetail.Add(clientInfoModel);
        }

        private void ShowAccountTypes()
        {
            AuditDetailsClient auditClient = new AuditDetailsClient();
            var accountTypesData = auditClient.GetAccountsTypeData();
            AccountsTypes = new ObservableCollection<AccountsAuditTypeModel>();
            foreach (var accountType in accountTypesData)
            {
                AccountsAuditTypeModel accountData = new AccountsAuditTypeModel();
                accountData.Id = accountType.AccountId;
                accountData.AccountsTypeCode = accountType.AccountTypeCode;
                accountData.AccountsType = accountType.AccountType;
                accountData.Limit = accountType.Limit;
                accountData.LastUpdated = accountType.DateUpdated;
                AccountsTypes.Add(accountData);
            }
        }

        private void ShowTurnoverypes()
        {
            AuditDetailsClient auditClient = new AuditDetailsClient();
            var turnOverData = auditClient.GetTurnoverTypeData();
            TurnoverTypes = new ObservableCollection<TurnoverModel>();
            foreach (var turnOver in turnOverData)
            {
                TurnoverModel turnOverValue = new TurnoverModel();
                turnOverValue.Id = turnOver.Id;
                turnOverValue.TurnoverType = turnOver.TurnOverType;
                turnOverValue.DateUpdated = turnOver.DateUpdated;
                TurnoverTypes.Add(turnOverValue);
            }
        }

        public ICommand SaveAuditDetailsCommand { get { return new RelayCommand(SaveNewAuditDetails, CanSaveNewAudit); } }
        private bool CanSaveNewAudit()
        {
            return true;
        }

        private void SaveNewAuditDetails()
        {
            AuditDetailsClient auditClient = new AuditDetailsClient();
            CAClient.Management.Models.AuditDetailsModel auditDetailsModel = new Management.Models.AuditDetailsModel();
            auditDetailsModel.ClientId = AuditModel.ClientId;
            //auditDetailsModel.AccountTypeId = ;
            //auditDetailsModel.TurnoverTypeId = ;
            auditDetailsModel.ProfRecNumber = Guid.NewGuid().ToString();
            auditDetailsModel.TuronOverMoney = auditModel.TuronOverMoney;
            auditDetailsModel.AuditRequired = auditModel.AuditRequired;
            auditDetailsModel.AuditStartDate = auditModel.AuditStartDate;
            auditDetailsModel.AuditEndDate = auditModel.AuditEndDate;
            auditDetailsModel.AuditBy = Convert.ToInt32(auditModel.AuditBy);
            auditDetailsModel.AuditFee = auditModel.AuditFee;
            auditClient.AddNewAudit(auditDetailsModel);
        }
    }
}
