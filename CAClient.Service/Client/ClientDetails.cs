using CAClient.Business.Layer.Client;
using CAClient.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAClient.Service.Client
{
    public class ClientDetails : IClientDetails
    {
        public List<ClientInformationModel> GetClientData()
        {
            ClientInfo clientInfo = new ClientInfo();
            var clientData = clientInfo.GetDataClientData();
            return clientData;
        }

        public void AddClientData(ClientInformationModel clientData)
        {
            ClientInfo clientInfo = new ClientInfo();
            clientInfo.AddClientData(clientData);
        }

        public void DeleteClientDetails(int clientId)
        {
            ClientInfo clientInfo = new ClientInfo();
            clientInfo.DeleteClientDetails(clientId);
        }

        public void EditClientDetails(ClientInformationModel clientData)
        {
            ClientInfo clientInfo = new ClientInfo();
            clientInfo.EditClientDetails(clientData);
        }

        public ClientInformationModel GetSingeClientData(int clientId)
        {
            ClientInfo clientInfo = new ClientInfo();
            var clientData = clientInfo.GetClientData(clientId);
            return clientData;
        }
    }
}