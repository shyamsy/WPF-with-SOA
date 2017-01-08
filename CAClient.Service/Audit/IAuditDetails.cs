using CAClient.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Service.Audit
{
    [ServiceContract]
   public interface IAuditDetails
    {
        [OperationContract]
       void AddAuditAccountType(AuditAccountType accountType);

        [OperationContract]
        List<AuditAccountType> GetAccountsTypeData();

        [OperationContract]
        void AddTurnOverType(TurnoverTypeModel turnOverType);

        [OperationContract]
        List<TurnoverTypeModel> GetTurnoverTypeData();

        [OperationContract]
        void AddNewAudit(AuditDetailsModel auditDetails);

        [OperationContract]
        List<AuditDetailsModel> GetAllAuditRecords();
    }
}
