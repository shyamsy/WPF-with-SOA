using CAClient.Frontend.MvvmBase;
using CAClient.Frontend.UIModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CAClient.Frontend.Client
{
    public class ClientInfoDetailsViewModel : ViewModelBase
    {

        public ClientInfoDetailsViewModel()
        {
            GetClientInfoDetails();
        }

        private ObservableCollection<ClientInformationModel> clientDetail;
        public ObservableCollection<ClientInformationModel> ClientDetail
        {
            get { return clientDetail; }
            set { clientDetail = value; }
        }

        private ClientInformationModel clientSelected;
        public ClientInformationModel ClientSelected
        {
            get { return clientSelected; }
            set
            {
                clientSelected = value;
                OnPropertyChanged("ClientSelected");
            }
        }

        public ICommand Close
        {
            get
            {
                return new RelayCommand(CloseWindow, null);
            }
        }

        private void CloseWindow()
        {

        }

        public ICommand DeleteClientCommand
        {
            get { return new RelayCommand(DeleteClient, CanDeleteClient); }
        }

        private bool CanDeleteClient()
        {
            return true;
        }

        public ICommand EditClientDetailsCommand
        {
            get { return new RelayCommand(EditClientDetails, CanEditClient); }
        }

        private bool CanEditClient()
        {
            return true;
        }

        private void EditClientDetails()
        {
            
            AddClientViewModel clientViewModel = new AddClientViewModel();
            clientViewModel.ClientInfoModel = ClientSelected;
            clientViewModel.Title = "Edit Client Details";
            clientViewModel.isEdit = true;
            AddClientView clientInfo = new AddClientView();
            clientInfo.DataContext = clientViewModel;
            clientInfo.Show();
        }

        private void DeleteClient()
        {
            var result = MessageBox.Show("Do You Really Want to Delete Client?", "Delete Client", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                ClientDetailsClient client = new ClientDetailsClient();
                int clientId = 0;
                if (ClientSelected != null)
                    clientId = ClientSelected.ClientId;

                client.DeleteClientDetails(clientId);
                ClientDetail.Remove(ClientSelected);
                MessageBox.Show("Client Record Deleted Successfully", "Delete Client", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        public void GetClientInfoDetails()
        {
            ClientDetailsClient client = new ClientDetailsClient();
            var clientInfo = client.GetClientData();
            ClientDetail = new ObservableCollection<ClientInformationModel>();

            foreach (var item in clientInfo)
            {
                ClientInformationModel clientInfoModel = new ClientInformationModel();
                clientInfoModel.ClientId = item.ClientId;
                clientInfoModel.FirstName = item.FirstName;
                clientInfoModel.MiddleName = item.MiddleName;
                clientInfoModel.LastName = item.LastName;
                clientInfoModel.Address = item.Address;
                clientInfoModel.City = item.City;
                clientInfoModel.Country = item.Country;
                clientInfoModel.PinCode = item.PinCode;
                clientInfoModel.PhoneNumber = item.PhoneNumber;
                clientInfoModel.LastUpdated = item.LastUpdated;
                ClientDetail.Add(clientInfoModel);
            }
        }
    }
}
