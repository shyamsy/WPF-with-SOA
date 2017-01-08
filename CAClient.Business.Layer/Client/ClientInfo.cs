using CAClient.DataAccess.Layer.Client;
using CAClient.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Business.Layer.Client
{
    public class ClientInfo
    {
        public List<ClientInformationModel> GetDataClientData()
        {
            ClientDetails data = new ClientDetails();
            var clientsData = data.GetClientsData();
            return clientsData;
        }

        public void AddClientData(ClientInformationModel clientData)
        {
            ClientDetails clientDetail = new ClientDetails();
            clientDetail.AddClientData(clientData);
        }

        public void DeleteClientDetails(int clientId)
        {
            ClientDetails clientDetail = new ClientDetails();
            clientDetail.DeleteClientDetails(clientId);
        }

        public void EditClientDetails(ClientInformationModel clientData)
        {
            ClientDetails clientDetail = new ClientDetails();
            clientDetail.EditClientDetails(clientData);
        }

        public ClientInformationModel GetClientData(int clientId)
        {
            ClientDetails clientDetail = new ClientDetails();
            var clientData = clientDetail.GetClientData(clientId);
            return clientData;
        }
    }
}
