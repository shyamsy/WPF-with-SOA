using CAClient.Business.Layer.Audit;
using CAClient.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAClient.Service.Audit
{
    public class AuditDetails : IAuditDetails
    {
        public void AddAuditAccountType(AuditAccountType accountType)
        {
            AuditDetailsBal audit = new AuditDetailsBal();
            audit.AddAuditAccountType(accountType);
        }


        public List<AuditAccountType> GetAccountsTypeData()
        {
            AuditDetailsBal audit = new AuditDetailsBal();
            var accountTypeData = audit.GetAccountsTypeData();
            return accountTypeData;
        }


        public void AddTurnOverType(TurnoverTypeModel turnOverType)
        {
            AuditDetailsBal audit = new AuditDetailsBal();
            audit.AddTurnOverType(turnOverType);
        }


        public List<TurnoverTypeModel> GetTurnoverTypeData()
        {
            AuditDetailsBal audit = new AuditDetailsBal();
            return audit.GetTurnoverTypeData();
        }

        public void AddNewAudit(AuditDetailsModel auditDetails)
        {
            AuditDetailsBal audit = new AuditDetailsBal();
            audit.AddNewAudit(auditDetails);
        }

        public List<AuditDetailsModel> GetAllAuditRecords()
        {
            AuditDetailsBal audit = new AuditDetailsBal();
            return audit.GetAllAuditRecords();
        }
    }
}