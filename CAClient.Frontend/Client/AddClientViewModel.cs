using CAClient.Frontend.MvvmBase;
using CAClient.Frontend.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace CAClient.Frontend.Client
{
    public class AddClientViewModel : ViewModelBase
    {
        public ClientInformationModel ClientInfoModel { get; set; }


        public AddClientViewModel()
        {
            ClientInfoModel = new ClientInformationModel();
            CountryDetails = new ObservableCollection<CountryInformationModel>();
            GetCountry();
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public bool isEdit;
        public bool IsEdit
        {
            get { return isEdit; }
            set
            {
                isEdit = value;
                OnPropertyChanged("IsEdit");
            }
        }

        private ObservableCollection<CountryInformationModel> countryDetails;
        public ObservableCollection<CountryInformationModel> CountryDetails
        {
            get { return countryDetails; }
            set { countryDetails = value; }
        }

        public ICommand AddClientDataCommand
        {
            get
            {
                return new RelayCommand(ProcessClientData, CanAddClientData);
            }
        }

        private bool CanAddClientData()
        {
            return true;
        }

        public void ProcessClientData()
        {
            if (!isEdit)
                AddClientData();
            else
                UpdateClientData();

        }

        public void AddClientData()
        {
            var result = MessageBox.Show("Do You Want to Add New Client?", "Add Client", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                ClientDetailsClient client = new ClientDetailsClient();
                CAClient.Management.Models.ClientInformationModel clientModel = new CAClient.Management.Models.ClientInformationModel();
                clientModel.FirstName = ClientInfoModel.FirstName;
                clientModel.MiddleName = ClientInfoModel.MiddleName;
                clientModel.LastName = ClientInfoModel.LastName;
                clientModel.Address = ClientInfoModel.Address;
                clientModel.City = ClientInfoModel.City;
                clientModel.State = ClientInfoModel.State;
                clientModel.Country = ClientInfoModel.Country;
                clientModel.PinCode = ClientInfoModel.PinCode;
                clientModel.PhoneNumber = ClientInfoModel.PhoneNumber;
                client.AddClientData(clientModel);
                ResetClientInfo();
                MessageBox.Show("Client Details Addedd", "Add Client", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public void UpdateClientData()
        {
            var result = MessageBox.Show("Do You Really Want to Update Client?", "Update Client Details", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                ClientDetailsClient client = new ClientDetailsClient();
                CAClient.Management.Models.ClientInformationModel clientModel = new CAClient.Management.Models.ClientInformationModel();
                clientModel.ClientId = ClientInfoModel.ClientId;
                clientModel.FirstName = ClientInfoModel.FirstName;
                clientModel.MiddleName = ClientInfoModel.MiddleName;
                clientModel.LastName = ClientInfoModel.LastName;
                clientModel.Address = ClientInfoModel.Address;
                clientModel.City = ClientInfoModel.City;
                clientModel.State = ClientInfoModel.State;
                clientModel.Country = ClientInfoModel.Country;
                clientModel.PinCode = ClientInfoModel.PinCode;
                clientModel.PhoneNumber = ClientInfoModel.PhoneNumber;
                client.EditClientDetails(clientModel);
                ResetClientInfo();
                MessageBox.Show("Client Details Updated", "Update Client Details", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ResetClientInfo()
        {
            ClientInfoModel.FirstName = string.Empty;
            ClientInfoModel.MiddleName = string.Empty;
            ClientInfoModel.LastName = string.Empty;
            ClientInfoModel.Address = string.Empty;
            ClientInfoModel.City = string.Empty;
            ClientInfoModel.State = string.Empty;
            ClientInfoModel.Country = string.Empty;
            ClientInfoModel.PinCode = string.Empty;
            ClientInfoModel.PhoneNumber = string.Empty;
        }

        private void GetCountry()
        {
            CountryDetailsClient countryDetailsClient = new CountryDetailsClient();
            var countryData = countryDetailsClient.GetCountryData();
            foreach (var country in countryData)
            {
                CountryDetails.Add(new CountryInformationModel { CountryId = country.CountryId, Name = country.Name });
            }
        }
    }
}
