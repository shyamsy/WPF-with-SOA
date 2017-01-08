using CAClient.DataAccess.Layer.Audit;
using CAClient.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Business.Layer.Audit
{
    public class AuditDetailsBal
    {
        public void AddAuditAccountType(AuditAccountType accountType)
        {
            AuditDetailsDal auditDetails = new AuditDetailsDal();
            auditDetails.AddAuditAccountType(accountType);
        }

        public List<AuditAccountType> GetAccountsTypeData()
        {
            AuditDetailsDal auditDetails = new AuditDetailsDal();
            return auditDetails.GetAccountsTypeData();
        }

        public void AddTurnOverType(TurnoverTypeModel turnOverType)
        {
            AuditDetailsDal auditDetails = new AuditDetailsDal();
            auditDetails.AddTurnOverType(turnOverType);
        }

        public List<TurnoverTypeModel> GetTurnoverTypeData()
        {
            AuditDetailsDal auditDetails = new AuditDetailsDal();
            return auditDetails.GetTurnoverTypeData();
        }

        public void AddNewAudit(AuditDetailsModel auditDetails)
        {
            AuditDetailsDal audit = new AuditDetailsDal();
            audit.AddNewAudit(auditDetails);
        }

        public List<AuditDetailsModel> GetAllAuditRecords()
        {
            AuditDetailsDal audit = new AuditDetailsDal();
            return audit.GetAllAuditRecords();
        }
    }
}
