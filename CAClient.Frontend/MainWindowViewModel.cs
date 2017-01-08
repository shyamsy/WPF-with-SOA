using CAClient.Frontend.Audit;
using CAClient.Frontend.Client;
using CAClient.Frontend.Configurations;
using CAClient.Frontend.MvvmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CAClient.Frontend
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand OpenClientDetailsMenu
        {
            get
            {
                return new RelayCommand(OpenClientDetails, CanOpenClientDetails);
            }
        }

        private void OpenClientDetails()
        {
            ClientInfoView clientInfo = new ClientInfoView();
            clientInfo.Show();
        }

        private bool CanOpenClientDetails()
        {
            return true;
        }

        public ICommand AddClientMenu
        {
            get { return new RelayCommand(OpenAddClient, CanAddClient); }
        }

        private bool CanAddClient()
        {
            return true;
        }

        public ICommand AuditAccountsMenu
        {
            get { return new RelayCommand(OpenAuditAccountsMenu, CanAuditAccountsMenu); }
        }

        private bool CanAuditAccountsMenu()
        {
            return true;
        }

        private void OpenAuditAccountsMenu()
        {
            AuditAccountsViewModel auditVm = new AuditAccountsViewModel();
            AuditAccountsView auditAccounts = new AuditAccountsView();
            auditAccounts.DataContext = auditVm;
            auditAccounts.Show();
        }

        private void OpenAddClient()
        {
            AddClientViewModel addClientVm = new AddClientViewModel();
            addClientVm.Title = "Add Client Details";
            addClientVm.isEdit = false;
            AddClientView addClient = new AddClientView();
            addClient.DataContext = addClientVm;
            addClient.Show();
        }

        public ICommand TurnoverMenu
        {
            get { return new RelayCommand(OpenTurnoverMenu, CanTurnoverMenu); }
        }

        private bool CanTurnoverMenu()
        {
            return true;
        }

        private void OpenTurnoverMenu()
        {
            TurnoverViewModel turoverViewModel = new TurnoverViewModel();
            TurnoverView turnOverView = new TurnoverView();
            turnOverView.DataContext = turoverViewModel;
            turnOverView.Show();
        }

        public ICommand NewAuditMenu
        {
            get { return new RelayCommand(OpenNewAudit, CanOpenNewAudit); }
        }

        private bool CanOpenNewAudit()
        {
            return true;
        }

        private void OpenNewAudit()
        {
            NewAuditViewModel newAuditViewModel = new NewAuditViewModel();
            newAuditViewModel.NewAuditTitle = "Add New Audit Record";
            NewAuditView newAuditView = new NewAuditView();
            newAuditView.DataContext = newAuditViewModel;
            newAuditView.Show();
        }

        public ICommand AuditDetailsMenu
        {
            get { return new RelayCommand(OpenAuditDetails, CanOpenAuditDetails); }
        }

        private bool CanOpenAuditDetails()
        {
            return true;
        }

        private void OpenAuditDetails()
        {
            AuditDetailsViewModel auditDetailsViewModel = new AuditDetailsViewModel();
            AuditDetailsView auditDetailsView = new AuditDetailsView();
            auditDetailsView.DataContext = auditDetailsViewModel;
            auditDetailsView.Show();
        }

        public ICommand AddNewCAMenu
        {
            get { return new RelayCommand(AddNewCa, CanAddNewCa); }
        }

        private bool CanAddNewCa()
        {
            return true;
        }

        private void AddNewCa()
        {
            AddCAViewModel addCaViewModel = new AddCAViewModel();
            AddCAView addCaView = new AddCAView();
            addCaView.DataContext = addCaViewModel;
            addCaView.Show();
        }

        public ICommand AddNewDesignationMenu
        {
            get { return new RelayCommand(OpenNewDesignation, CanOpenNewDesignation); }
        }

        private bool CanOpenNewDesignation()
        {
            return true;
        }

        private void OpenNewDesignation()
        {
            AddDesignationViewModel addDesignationViewModel = new AddDesignationViewModel();
            AddDesignationView addDesignationView = new AddDesignationView();
            addDesignationView.DataContext = addDesignationViewModel;
            addDesignationView.Show();
        }

        public ICommand CaDetailsMenu
        {
            get { return new RelayCommand(OpenCaDetailsMenu, CanCaDetailsMenu); }
        }

        private bool CanCaDetailsMenu()
        {
            return true;
        }

        private void OpenCaDetailsMenu()
        {
            CaDetailsViewModel caDetailsViewModel = new CaDetailsViewModel();
            CaDetailsView caDetailsView = new CaDetailsView();
            caDetailsView.DataContext = caDetailsViewModel;
            caDetailsView.Show();
        }
    }
}
