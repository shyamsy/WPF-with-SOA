using CAClient.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Service.Client
{
    [ServiceContract]
    public interface IClientDetails
    {

        [OperationContract]
        List<ClientInformationModel> GetClientData();

        [OperationContract]
        void AddClientData(ClientInformationModel clientData);

        [OperationContract]
        void DeleteClientDetails(int clientId);

        [OperationContract]
        void EditClientDetails(ClientInformationModel clientData);

        [OperationContract]
        ClientInformationModel GetSingeClientData(int clientId);
    }
}
