using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using CAClient.DataAccess.Layer.DALUtils;
using CAClient.Management.Models;

namespace CAClient.DataAccess.Layer.Client
{
    public class ClientDetails
    {
        public List<ClientInformationModel> GetClientsData()
        {
            List<ClientInformationModel> ClientsData = new List<ClientInformationModel>();

            try
            {
                var database = SingletonDb.Instance.GetDBConnection();
                object[] parameterValues = new object[] { 1 };
                DbCommand cmd = database.GetStoredProcCommand("dbo.Client_sp_Select", parameterValues);

                using (IDataReader reader = database.ExecuteReader(cmd))
                {
                    while (reader.Read())
                    {
                        ClientInformationModel ClientInfo = new ClientInformationModel();
                        ClientInfo.ClientId = reader.GetInt32(0);
                        ClientInfo.FirstName = !reader.IsDBNull(reader.GetOrdinal("vc_FirstName")) ? reader.GetString(1) : string.Empty;
                        ClientInfo.MiddleName = !reader.IsDBNull(reader.GetOrdinal("vc_MiddleName")) ? reader.GetString(2) : string.Empty;
                        ClientInfo.LastName = !reader.IsDBNull(reader.GetOrdinal("vc_LastName")) ? reader.GetString(3) : string.Empty;
                        ClientInfo.PhoneNumber = !reader.IsDBNull(reader.GetOrdinal("in_PhoneNo")) ? reader.GetString(4) : string.Empty;
                        ClientInfo.Address = !reader.IsDBNull(reader.GetOrdinal("vc_ClientAddress")) ? reader.GetString(5) : string.Empty;
                        ClientInfo.City = !reader.IsDBNull(reader.GetOrdinal("vc_ClientCity")) ? reader.GetString(6) : string.Empty;
                        ClientInfo.State = !reader.IsDBNull(reader.GetOrdinal("vc_ClientState")) ? reader.GetString(7) : string.Empty;
                        ClientInfo.Country = !reader.IsDBNull(reader.GetOrdinal("vc_ClientCountry")) ? reader.GetString(8) : string.Empty;
                        ClientInfo.PinCode = !reader.IsDBNull(reader.GetOrdinal("in_ClientPINcode")) ? reader.GetString(9) : string.Empty;
                        ClientInfo.LastUpdated = !reader.IsDBNull(reader.GetOrdinal("dt_lastUpdateDate")) ? reader.GetDateTime(10) : DateTime.Now;
                        ClientsData.Add(ClientInfo);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return ClientsData;
        }

        public void AddClientData(ClientInformationModel clientData)
        {
            try
            {
                var database = SingletonDb.Instance.GetDBConnection();
                object[] parameterValues = new object[] { 2, clientData.FirstName, clientData.MiddleName, clientData.LastName, clientData.PhoneNumber,
                clientData.PhoneNumber, clientData.Address, clientData.City, clientData.Country, clientData.PinCode};
                DbCommand cmd = database.GetStoredProcCommand("dbo.client_sp_details", parameterValues);
                database.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {

            }
        }

        public void DeleteClientDetails(int clientId)
        {
            var database = SingletonDb.Instance.GetDBConnection();
            object[] parameter = new object[] { clientId };
            DbCommand cmd = database.GetStoredProcCommand("dbo.Client_sp_Delete", parameter);
            database.ExecuteNonQuery(cmd);
        }

        public void EditClientDetails(ClientInformationModel clientData)
        {
            var database = SingletonDb.Instance.GetDBConnection();
            object[] parameter = new object[] { clientData.ClientId, clientData.FirstName, clientData.MiddleName, clientData.LastName, clientData.PhoneNumber,
            clientData.Address, clientData.City, clientData.State, clientData.Country, clientData.PinCode};
            DbCommand cmd = database.GetStoredProcCommand("dbo.Client_sp_Update", parameter);
            database.ExecuteNonQuery(cmd);
        }

        public ClientInformationModel GetClientData(int clientId)
        {
            ClientInformationModel ClientInfo = new ClientInformationModel();

            try
            {
                var database = SingletonDb.Instance.GetDBConnection();
                object[] parameterValues = new object[] { clientId };
                DbCommand cmd = database.GetStoredProcCommand("dbo.Client_sp_SelectByClientId", parameterValues);

                using (IDataReader reader = database.ExecuteReader(cmd))
                {
                    while (reader.Read())
                    {
                        
                        ClientInfo.ClientId = reader.GetInt32(0);
                        ClientInfo.FirstName = !reader.IsDBNull(reader.GetOrdinal("vc_FirstName")) ? reader.GetString(1) : string.Empty;
                        ClientInfo.MiddleName = !reader.IsDBNull(reader.GetOrdinal("vc_MiddleName")) ? reader.GetString(2) : string.Empty;
                        ClientInfo.LastName = !reader.IsDBNull(reader.GetOrdinal("vc_LastName")) ? reader.GetString(3) : string.Empty;
                        ClientInfo.PhoneNumber = !reader.IsDBNull(reader.GetOrdinal("in_PhoneNo")) ? reader.GetString(4) : string.Empty;
                        ClientInfo.Address = !reader.IsDBNull(reader.GetOrdinal("vc_ClientAddress")) ? reader.GetString(5) : string.Empty;
                        ClientInfo.City = !reader.IsDBNull(reader.GetOrdinal("vc_ClientCity")) ? reader.GetString(6) : string.Empty;
                        ClientInfo.State = !reader.IsDBNull(reader.GetOrdinal("vc_ClientState")) ? reader.GetString(7) : string.Empty;
                        ClientInfo.Country = !reader.IsDBNull(reader.GetOrdinal("vc_ClientCountry")) ? reader.GetString(8) : string.Empty;
                        ClientInfo.PinCode = !reader.IsDBNull(reader.GetOrdinal("in_ClientPINcode")) ? reader.GetString(9) : string.Empty;
                        ClientInfo.LastUpdated = !reader.IsDBNull(reader.GetOrdinal("dt_lastUpdateDate")) ? reader.GetDateTime(10) : DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return ClientInfo;
        }

    }
}
