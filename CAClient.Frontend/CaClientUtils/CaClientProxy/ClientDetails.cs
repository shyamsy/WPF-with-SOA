﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAClient.Management.Models
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientInformationModel", Namespace="http://schemas.datacontract.org/2004/07/CAClient.Management.Models")]
    public partial class ClientInformationModel : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AddressField;
        
        private string CityField;
        
        private int ClientIdField;
        
        private string CountryField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private System.DateTime LastUpdatedField;
        
        private string MiddleNameField;
        
        private string PhoneNumberField;
        
        private string PinCodeField;
        
        private string StateField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientId
        {
            get
            {
                return this.ClientIdField;
            }
            set
            {
                this.ClientIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country
        {
            get
            {
                return this.CountryField;
            }
            set
            {
                this.CountryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastUpdated
        {
            get
            {
                return this.LastUpdatedField;
            }
            set
            {
                this.LastUpdatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName
        {
            get
            {
                return this.MiddleNameField;
            }
            set
            {
                this.MiddleNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumberField;
            }
            set
            {
                this.PhoneNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PinCode
        {
            get
            {
                return this.PinCodeField;
            }
            set
            {
                this.PinCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State
        {
            get
            {
                return this.StateField;
            }
            set
            {
                this.StateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CountryModel", Namespace="http://schemas.datacontract.org/2004/07/CAClient.Management.Models")]
    public partial class CountryModel : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CommonNameField;
        
        private int CountryIdField;
        
        private string IsoField;
        
        private string Iso3Field;
        
        private string NameField;
        
        private int NumCodeField;
        
        private int PhonecodeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CommonName
        {
            get
            {
                return this.CommonNameField;
            }
            set
            {
                this.CommonNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CountryId
        {
            get
            {
                return this.CountryIdField;
            }
            set
            {
                this.CountryIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Iso
        {
            get
            {
                return this.IsoField;
            }
            set
            {
                this.IsoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Iso3
        {
            get
            {
                return this.Iso3Field;
            }
            set
            {
                this.Iso3Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumCode
        {
            get
            {
                return this.NumCodeField;
            }
            set
            {
                this.NumCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Phonecode
        {
            get
            {
                return this.PhonecodeField;
            }
            set
            {
                this.PhonecodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuditAccountType", Namespace="http://schemas.datacontract.org/2004/07/CAClient.Management.Models")]
    public partial class AuditAccountType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int AccountIdField;
        
        private string AccountTypeField;
        
        private string AccountTypeCodeField;
        
        private System.DateTime DateUpdatedField;
        
        private string LimitField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AccountId
        {
            get
            {
                return this.AccountIdField;
            }
            set
            {
                this.AccountIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AccountType
        {
            get
            {
                return this.AccountTypeField;
            }
            set
            {
                this.AccountTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AccountTypeCode
        {
            get
            {
                return this.AccountTypeCodeField;
            }
            set
            {
                this.AccountTypeCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateUpdated
        {
            get
            {
                return this.DateUpdatedField;
            }
            set
            {
                this.DateUpdatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Limit
        {
            get
            {
                return this.LimitField;
            }
            set
            {
                this.LimitField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TurnoverTypeModel", Namespace="http://schemas.datacontract.org/2004/07/CAClient.Management.Models")]
    public partial class TurnoverTypeModel : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime DateUpdatedField;
        
        private int IdField;
        
        private string TurnOverTypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateUpdated
        {
            get
            {
                return this.DateUpdatedField;
            }
            set
            {
                this.DateUpdatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TurnOverType
        {
            get
            {
                return this.TurnOverTypeField;
            }
            set
            {
                this.TurnOverTypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuditDetailsModel", Namespace="http://schemas.datacontract.org/2004/07/CAClient.Management.Models")]
    public partial class AuditDetailsModel : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int AccountTypeIdField;
        
        private int AuditByField;
        
        private System.DateTime AuditEndDateField;
        
        private double AuditFeeField;
        
        private int AuditIdField;
        
        private bool AuditRequiredField;
        
        private System.DateTime AuditStartDateField;
        
        private int ClientIdField;
        
        private string ProfRecNumberField;
        
        private int ProfReceiptMoneyField;
        
        private int TurnoverTypeIdField;
        
        private int TuronOverMoneyField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AccountTypeId
        {
            get
            {
                return this.AccountTypeIdField;
            }
            set
            {
                this.AccountTypeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AuditBy
        {
            get
            {
                return this.AuditByField;
            }
            set
            {
                this.AuditByField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AuditEndDate
        {
            get
            {
                return this.AuditEndDateField;
            }
            set
            {
                this.AuditEndDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double AuditFee
        {
            get
            {
                return this.AuditFeeField;
            }
            set
            {
                this.AuditFeeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AuditId
        {
            get
            {
                return this.AuditIdField;
            }
            set
            {
                this.AuditIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AuditRequired
        {
            get
            {
                return this.AuditRequiredField;
            }
            set
            {
                this.AuditRequiredField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AuditStartDate
        {
            get
            {
                return this.AuditStartDateField;
            }
            set
            {
                this.AuditStartDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientId
        {
            get
            {
                return this.ClientIdField;
            }
            set
            {
                this.ClientIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProfRecNumber
        {
            get
            {
                return this.ProfRecNumberField;
            }
            set
            {
                this.ProfRecNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProfReceiptMoney
        {
            get
            {
                return this.ProfReceiptMoneyField;
            }
            set
            {
                this.ProfReceiptMoneyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TurnoverTypeId
        {
            get
            {
                return this.TurnoverTypeIdField;
            }
            set
            {
                this.TurnoverTypeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TuronOverMoney
        {
            get
            {
                return this.TuronOverMoneyField;
            }
            set
            {
                this.TuronOverMoneyField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IClientDetails")]
public interface IClientDetails
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDetails/GetClientData", ReplyAction="http://tempuri.org/IClientDetails/GetClientDataResponse")]
    CAClient.Management.Models.ClientInformationModel[] GetClientData();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDetails/GetClientData", ReplyAction="http://tempuri.org/IClientDetails/GetClientDataResponse")]
    System.Threading.Tasks.Task<CAClient.Management.Models.ClientInformationModel[]> GetClientDataAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDetails/AddClientData", ReplyAction="http://tempuri.org/IClientDetails/AddClientDataResponse")]
    void AddClientData(CAClient.Management.Models.ClientInformationModel clientData);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDetails/AddClientData", ReplyAction="http://tempuri.org/IClientDetails/AddClientDataResponse")]
    System.Threading.Tasks.Task AddClientDataAsync(CAClient.Management.Models.ClientInformationModel clientData);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDetails/DeleteClientDetails", ReplyAction="http://tempuri.org/IClientDetails/DeleteClientDetailsResponse")]
    void DeleteClientDetails(int clientId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDetails/DeleteClientDetails", ReplyAction="http://tempuri.org/IClientDetails/DeleteClientDetailsResponse")]
    System.Threading.Tasks.Task DeleteClientDetailsAsync(int clientId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDetails/EditClientDetails", ReplyAction="http://tempuri.org/IClientDetails/EditClientDetailsResponse")]
    void EditClientDetails(CAClient.Management.Models.ClientInformationModel clientData);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDetails/EditClientDetails", ReplyAction="http://tempuri.org/IClientDetails/EditClientDetailsResponse")]
    System.Threading.Tasks.Task EditClientDetailsAsync(CAClient.Management.Models.ClientInformationModel clientData);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDetails/GetSingeClientData", ReplyAction="http://tempuri.org/IClientDetails/GetSingeClientDataResponse")]
    CAClient.Management.Models.ClientInformationModel GetSingeClientData(int clientId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientDetails/GetSingeClientData", ReplyAction="http://tempuri.org/IClientDetails/GetSingeClientDataResponse")]
    System.Threading.Tasks.Task<CAClient.Management.Models.ClientInformationModel> GetSingeClientDataAsync(int clientId);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IClientDetailsChannel : IClientDetails, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ClientDetailsClient : System.ServiceModel.ClientBase<IClientDetails>, IClientDetails
{
    
    public ClientDetailsClient()
    {
    }
    
    public ClientDetailsClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ClientDetailsClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ClientDetailsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ClientDetailsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public CAClient.Management.Models.ClientInformationModel[] GetClientData()
    {
        return base.Channel.GetClientData();
    }
    
    public System.Threading.Tasks.Task<CAClient.Management.Models.ClientInformationModel[]> GetClientDataAsync()
    {
        return base.Channel.GetClientDataAsync();
    }
    
    public void AddClientData(CAClient.Management.Models.ClientInformationModel clientData)
    {
        base.Channel.AddClientData(clientData);
    }
    
    public System.Threading.Tasks.Task AddClientDataAsync(CAClient.Management.Models.ClientInformationModel clientData)
    {
        return base.Channel.AddClientDataAsync(clientData);
    }
    
    public void DeleteClientDetails(int clientId)
    {
        base.Channel.DeleteClientDetails(clientId);
    }
    
    public System.Threading.Tasks.Task DeleteClientDetailsAsync(int clientId)
    {
        return base.Channel.DeleteClientDetailsAsync(clientId);
    }
    
    public void EditClientDetails(CAClient.Management.Models.ClientInformationModel clientData)
    {
        base.Channel.EditClientDetails(clientData);
    }
    
    public System.Threading.Tasks.Task EditClientDetailsAsync(CAClient.Management.Models.ClientInformationModel clientData)
    {
        return base.Channel.EditClientDetailsAsync(clientData);
    }
    
    public CAClient.Management.Models.ClientInformationModel GetSingeClientData(int clientId)
    {
        return base.Channel.GetSingeClientData(clientId);
    }
    
    public System.Threading.Tasks.Task<CAClient.Management.Models.ClientInformationModel> GetSingeClientDataAsync(int clientId)
    {
        return base.Channel.GetSingeClientDataAsync(clientId);
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICountryDetails")]
public interface ICountryDetails
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryDetails/GetCountryData", ReplyAction="http://tempuri.org/ICountryDetails/GetCountryDataResponse")]
    CAClient.Management.Models.CountryModel[] GetCountryData();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryDetails/GetCountryData", ReplyAction="http://tempuri.org/ICountryDetails/GetCountryDataResponse")]
    System.Threading.Tasks.Task<CAClient.Management.Models.CountryModel[]> GetCountryDataAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICountryDetailsChannel : ICountryDetails, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CountryDetailsClient : System.ServiceModel.ClientBase<ICountryDetails>, ICountryDetails
{
    
    public CountryDetailsClient()
    {
    }
    
    public CountryDetailsClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CountryDetailsClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CountryDetailsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CountryDetailsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public CAClient.Management.Models.CountryModel[] GetCountryData()
    {
        return base.Channel.GetCountryData();
    }
    
    public System.Threading.Tasks.Task<CAClient.Management.Models.CountryModel[]> GetCountryDataAsync()
    {
        return base.Channel.GetCountryDataAsync();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IAuditDetails")]
public interface IAuditDetails
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/AddAuditAccountType", ReplyAction="http://tempuri.org/IAuditDetails/AddAuditAccountTypeResponse")]
    void AddAuditAccountType(CAClient.Management.Models.AuditAccountType accountType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/AddAuditAccountType", ReplyAction="http://tempuri.org/IAuditDetails/AddAuditAccountTypeResponse")]
    System.Threading.Tasks.Task AddAuditAccountTypeAsync(CAClient.Management.Models.AuditAccountType accountType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/GetAccountsTypeData", ReplyAction="http://tempuri.org/IAuditDetails/GetAccountsTypeDataResponse")]
    CAClient.Management.Models.AuditAccountType[] GetAccountsTypeData();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/GetAccountsTypeData", ReplyAction="http://tempuri.org/IAuditDetails/GetAccountsTypeDataResponse")]
    System.Threading.Tasks.Task<CAClient.Management.Models.AuditAccountType[]> GetAccountsTypeDataAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/AddTurnOverType", ReplyAction="http://tempuri.org/IAuditDetails/AddTurnOverTypeResponse")]
    void AddTurnOverType(CAClient.Management.Models.TurnoverTypeModel turnOverType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/AddTurnOverType", ReplyAction="http://tempuri.org/IAuditDetails/AddTurnOverTypeResponse")]
    System.Threading.Tasks.Task AddTurnOverTypeAsync(CAClient.Management.Models.TurnoverTypeModel turnOverType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/GetTurnoverTypeData", ReplyAction="http://tempuri.org/IAuditDetails/GetTurnoverTypeDataResponse")]
    CAClient.Management.Models.TurnoverTypeModel[] GetTurnoverTypeData();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/GetTurnoverTypeData", ReplyAction="http://tempuri.org/IAuditDetails/GetTurnoverTypeDataResponse")]
    System.Threading.Tasks.Task<CAClient.Management.Models.TurnoverTypeModel[]> GetTurnoverTypeDataAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/AddNewAudit", ReplyAction="http://tempuri.org/IAuditDetails/AddNewAuditResponse")]
    void AddNewAudit(CAClient.Management.Models.AuditDetailsModel auditDetails);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/AddNewAudit", ReplyAction="http://tempuri.org/IAuditDetails/AddNewAuditResponse")]
    System.Threading.Tasks.Task AddNewAuditAsync(CAClient.Management.Models.AuditDetailsModel auditDetails);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/GetAllAuditRecords", ReplyAction="http://tempuri.org/IAuditDetails/GetAllAuditRecordsResponse")]
    CAClient.Management.Models.AuditDetailsModel[] GetAllAuditRecords();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuditDetails/GetAllAuditRecords", ReplyAction="http://tempuri.org/IAuditDetails/GetAllAuditRecordsResponse")]
    System.Threading.Tasks.Task<CAClient.Management.Models.AuditDetailsModel[]> GetAllAuditRecordsAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IAuditDetailsChannel : IAuditDetails, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class AuditDetailsClient : System.ServiceModel.ClientBase<IAuditDetails>, IAuditDetails
{
    
    public AuditDetailsClient()
    {
    }
    
    public AuditDetailsClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public AuditDetailsClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AuditDetailsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AuditDetailsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void AddAuditAccountType(CAClient.Management.Models.AuditAccountType accountType)
    {
        base.Channel.AddAuditAccountType(accountType);
    }
    
    public System.Threading.Tasks.Task AddAuditAccountTypeAsync(CAClient.Management.Models.AuditAccountType accountType)
    {
        return base.Channel.AddAuditAccountTypeAsync(accountType);
    }
    
    public CAClient.Management.Models.AuditAccountType[] GetAccountsTypeData()
    {
        return base.Channel.GetAccountsTypeData();
    }
    
    public System.Threading.Tasks.Task<CAClient.Management.Models.AuditAccountType[]> GetAccountsTypeDataAsync()
    {
        return base.Channel.GetAccountsTypeDataAsync();
    }
    
    public void AddTurnOverType(CAClient.Management.Models.TurnoverTypeModel turnOverType)
    {
        base.Channel.AddTurnOverType(turnOverType);
    }
    
    public System.Threading.Tasks.Task AddTurnOverTypeAsync(CAClient.Management.Models.TurnoverTypeModel turnOverType)
    {
        return base.Channel.AddTurnOverTypeAsync(turnOverType);
    }
    
    public CAClient.Management.Models.TurnoverTypeModel[] GetTurnoverTypeData()
    {
        return base.Channel.GetTurnoverTypeData();
    }
    
    public System.Threading.Tasks.Task<CAClient.Management.Models.TurnoverTypeModel[]> GetTurnoverTypeDataAsync()
    {
        return base.Channel.GetTurnoverTypeDataAsync();
    }
    
    public void AddNewAudit(CAClient.Management.Models.AuditDetailsModel auditDetails)
    {
        base.Channel.AddNewAudit(auditDetails);
    }
    
    public System.Threading.Tasks.Task AddNewAuditAsync(CAClient.Management.Models.AuditDetailsModel auditDetails)
    {
        return base.Channel.AddNewAuditAsync(auditDetails);
    }
    
    public CAClient.Management.Models.AuditDetailsModel[] GetAllAuditRecords()
    {
        return base.Channel.GetAllAuditRecords();
    }
    
    public System.Threading.Tasks.Task<CAClient.Management.Models.AuditDetailsModel[]> GetAllAuditRecordsAsync()
    {
        return base.Channel.GetAllAuditRecordsAsync();
    }
}