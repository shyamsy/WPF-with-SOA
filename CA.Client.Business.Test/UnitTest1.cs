using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAClient.Service.Client;
using CAClient.Management.Models;

namespace CA.Client.Business.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClientDetails cl = new ClientDetails();
            var data = cl.GetClientData();
        }

        [TestMethod]
        public void AddClientData()
        {
            ClientInformationModel clientData = new ClientInformationModel();
            clientData.FirstName = "cc";
            clientData.MiddleName = "dd";
            clientData.LastName = "ddde";
            clientData.Address = "dddfsdaf";
            clientData.City = "bng";
            clientData.State = "dd";
            clientData.PhoneNumber = "111";
            clientData.PinCode = "333";
            ClientDetails cl = new ClientDetails();
            cl.AddClientData(clientData);
        }

        [TestMethod]
        public void DeleteClientDetails()
        {
            ClientDetails cl = new ClientDetails();
            int clientId = 237;
            cl.DeleteClientDetails(clientId);
        }
    }
}
