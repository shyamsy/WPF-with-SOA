using CAClient.Frontend.MvvmBase;
using CAClient.Frontend.UIModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CAClient.Frontend.Audit
{
    public class AuditDetailsViewModel : ViewModelBase
    {
        private AuditModel auditModel;
        public AuditModel AuditModel
        {
            get { return auditModel; }
            set
            {
                auditModel = value;
                OnPropertyChanged("AuditModel");
            }
        }

        private ObservableCollection<AuditModel> auditRecords;
        public ObservableCollection<AuditModel> AuditRecords
        {
            get { return auditRecords; }
            set
            {
                auditRecords = value;
                OnPropertyChanged("AuditRecords");
            }
        }

        private AuditModel auditRecord;
        public AuditModel AuditRecord
        {
            get { return auditRecord; }
            set { auditRecord = value;
            OnPropertyChanged("AuditRecord");
            }
        }

        public AuditDetailsViewModel()
        {
            AuditRecords = new ObservableCollection<AuditModel>();
            GetAudiRecords();
        }

        private void GetAudiRecords()
        {
            AuditDetailsClient auditClient = new AuditDetailsClient();
            var auditRecords = auditClient.GetAllAuditRecords();

            foreach (var item in auditRecords)
            {
                AuditModel audit = new AuditModel();
                audit.AuditId = item.AuditId;
                audit.ClientId = item.ClientId;
                audit.TuronOverMoney = item.TuronOverMoney;
                audit.AuditRequired = item.AuditRequired;
                audit.AuditStartDate = item.AuditStartDate;
                audit.AuditEndDate = item.AuditEndDate;
                audit.AuditBy = item.AuditBy.ToString();
                audit.AuditFee = item.AuditFee;
                AuditRecords.Add(audit);
            }
        }

        public ICommand EditAuditDetailCommand
        {
            get { return new RelayCommand(EditAuditDetail, CanEditAuditDetail); }
        }

        private bool CanEditAuditDetail()
        {
            return true;
        }

        private void EditAuditDetail()
        {
            NewAuditViewModel newAuditViewModel = new NewAuditViewModel();
            newAuditViewModel.NewAuditTitle = "Edit Audit Record.";
            newAuditViewModel.AuditModel.ClientId = AuditRecord.ClientId;
            newAuditViewModel.GetClientInfoDetails();
            newAuditViewModel.AuditModel = AuditRecord;
            NewAuditView newAuditView = new NewAuditView();
            newAuditView.DataContext = newAuditViewModel;
            newAuditView.Show();
        }

        public ICommand DeleteAuditDetailCommand
        {
            get { return new RelayCommand(DeleteAuditDetail, CanDeleteAudit); }
        }

        private bool CanDeleteAudit()
        {
            return true;
        }

        private void DeleteAuditDetail()
        {
            
        }
    }
}
