using CAClient.DataAccess.Layer.DALUtils;
using CAClient.Management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.DataAccess.Layer.Audit
{
    public class AuditDetailsDal
    {
        public void AddAuditAccountType(AuditAccountType accountType)
        {
            try
            {
                var database = SingletonDb.Instance.GetDBConnection();
                object[] parameterValues = new object[] { accountType.AccountType, accountType.AccountTypeCode, accountType.Limit };
                DbCommand cmd = database.GetStoredProcCommand("dbo.AccountType_sp_Insert", parameterValues);
                database.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {

            }
        }

        public List<AuditAccountType> GetAccountsTypeData()
        {
            List<AuditAccountType> accountTypesData = new List<AuditAccountType>();

            try
            {
                var database = SingletonDb.Instance.GetDBConnection();
                object[] parameterValues = new object[] { };
                DbCommand cmd = database.GetStoredProcCommand("dbo.AccountType_sp_Select", parameterValues);

                using (IDataReader reader = database.ExecuteReader(cmd))
                {
                    while (reader.Read())
                    {
                        AuditAccountType accountTypeInfo = new AuditAccountType();
                        accountTypeInfo.AccountId = reader.GetInt32(0);
                        accountTypeInfo.AccountTypeCode = !reader.IsDBNull(reader.GetOrdinal("vc_AccountTypeCode")) ? reader.GetString(1) : string.Empty;
                        accountTypeInfo.AccountType = !reader.IsDBNull(reader.GetOrdinal("vc_AccountType")) ? reader.GetString(2) : string.Empty;
                        accountTypeInfo.Limit = !reader.IsDBNull(reader.GetOrdinal("dc_LimitAmount")) ? reader.GetString(3) : string.Empty;
                        accountTypesData.Add(accountTypeInfo);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return accountTypesData;
        }

        #region TurnOverType

        public void AddTurnOverType(TurnoverTypeModel turnOverType)
        {
            try
            {
                var database = SingletonDb.Instance.GetDBConnection();
                object[] parameterValues = new object[] { turnOverType.TurnOverType };
                DbCommand cmd = database.GetStoredProcCommand("dbo.TurnOverType_sp_Insert", parameterValues);
                database.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {

            }
        }


        public List<TurnoverTypeModel> GetTurnoverTypeData()
        {
            List<TurnoverTypeModel> turnOverTypeData = new List<TurnoverTypeModel>();

            try
            {
                var database = SingletonDb.Instance.GetDBConnection();
                object[] parameterValues = new object[] { };
                DbCommand cmd = database.GetStoredProcCommand("dbo.TurnOverType_sp_Select", parameterValues);

                using (IDataReader reader = database.ExecuteReader(cmd))
                {
                    while (reader.Read())
                    {
                        TurnoverTypeModel turnOVerType = new TurnoverTypeModel();
                        turnOVerType.Id = reader.GetInt32(0);
                        turnOVerType.TurnOverType = !reader.IsDBNull(reader.GetOrdinal("vc_TurnOverType")) ? reader.GetString(1) : string.Empty;
                        turnOVerType.DateUpdated = !reader.IsDBNull(reader.GetOrdinal("dt_DateUpdated")) ? reader.GetDateTime(2) : DateTime.Now;
                        turnOverTypeData.Add(turnOVerType);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return turnOverTypeData;
        }


        #endregion

        #region Audit Details

        public void AddNewAudit(AuditDetailsModel auditDetails)
        {
            try
            {
                var database = SingletonDb.Instance.GetDBConnection();
                object[] parameterValues = new object[] { auditDetails.ClientId, auditDetails.AccountTypeId, auditDetails.TurnoverTypeId, auditDetails.ProfRecNumber,
                auditDetails.TuronOverMoney, auditDetails.AuditRequired, auditDetails.AuditStartDate, auditDetails.AuditEndDate, auditDetails.AuditBy, auditDetails.AuditFee};
                DbCommand cmd = database.GetStoredProcCommand("dbo.NewAudit_sp_Insert", parameterValues);
                database.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {

            }
        }

        public List<AuditDetailsModel> GetAllAuditRecords()
        {
            List<AuditDetailsModel> auditRecords = new List<AuditDetailsModel>();

            try
            {
                var database = SingletonDb.Instance.GetDBConnection();
                object[] parameterValues = new object[] { };
                DbCommand cmd = database.GetStoredProcCommand("dbo.NewAudit_sp_Select", parameterValues);

                using (IDataReader reader = database.ExecuteReader(cmd))
                {
                    while (reader.Read())
                    {
                        AuditDetailsModel auditRecord = new AuditDetailsModel();
                        auditRecord.AuditId = reader.GetInt32(0);
                        auditRecord.ClientId = !reader.IsDBNull(reader.GetOrdinal("in_ClientId")) ? reader.GetInt32(1) : 0;
                        auditRecord.AccountTypeId = !reader.IsDBNull(reader.GetOrdinal("in_AccountTypeID")) ? reader.GetInt32(2) : 0;
                        auditRecord.TurnoverTypeId = !reader.IsDBNull(reader.GetOrdinal("in_TurnOverTypeId")) ? reader.GetInt32(3) : 0;
                        auditRecord.ProfRecNumber = !reader.IsDBNull(reader.GetOrdinal("vc_ProfessionalReceipt")) ? reader.GetString(4) : string.Empty;
                        auditRecord.TuronOverMoney = !reader.IsDBNull(reader.GetOrdinal("in_TurnOver")) ? reader.GetInt32(5) : 0;
                        auditRecord.AuditRequired = !reader.IsDBNull(reader.GetOrdinal("bt_AuditRequired")) ? reader.GetBoolean(6) : false;
                        auditRecord.AuditStartDate = !reader.IsDBNull(reader.GetOrdinal("dt_AuditStartDate")) ? reader.GetDateTime(7) : DateTime.Now;
                        auditRecord.AuditEndDate = !reader.IsDBNull(reader.GetOrdinal("dt_AuditCompleteDate")) ? reader.GetDateTime(8) : DateTime.Now;
                        auditRecord.AuditBy = !reader.IsDBNull(reader.GetOrdinal("in_AuditByID")) ? reader.GetInt32(9) : 0;
                        auditRecord.AuditFee = !reader.IsDBNull(reader.GetOrdinal("in_AuditFee")) ? reader.GetInt32(10) : 0;
                        auditRecords.Add(auditRecord);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return auditRecords;
        }

        #endregion
    }
}
