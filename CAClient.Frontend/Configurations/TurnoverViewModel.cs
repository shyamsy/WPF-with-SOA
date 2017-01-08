using CAClient.Frontend.MvvmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CAClient.Frontend.UIModels;
using System.Windows.Input;

namespace CAClient.Frontend.Configurations
{
    public class TurnoverViewModel : ViewModelBase
    {

        public TurnoverViewModel()
        {
            TurnoverModel = new TurnoverModel();
            ShowTurnoverypes();
        }

        private TurnoverModel turnoverModel;
        public TurnoverModel TurnoverModel
        {
            get { return turnoverModel; }
            set
            {
                turnoverModel = value;
                OnPropertyChanged("TurnoverModel");
            }
        }

        private ObservableCollection<TurnoverModel> turnoverLists;
        public ObservableCollection<TurnoverModel> TurnoverLists
        {
            get { return turnoverLists; }
            set { turnoverLists = value;
            OnPropertyChanged("TurnoverLists");
            }
        }

        public ICommand SaveTurnoverCommand
        {
            get { return new RelayCommand(SaveTurnover, CanSaveTurnover); }
        }

        private bool CanSaveTurnover()
        {
            return true;
        }

        private void SaveTurnover()
        {
            AuditDetailsClient auditClient = new AuditDetailsClient();
            CAClient.Management.Models.TurnoverTypeModel turnOverType = new CAClient.Management.Models.TurnoverTypeModel();
            turnOverType.TurnOverType = TurnoverModel.TurnoverType;
            auditClient.AddTurnOverType(turnOverType);
            ShowTurnoverypes();
        }

        private void ShowTurnoverypes()
        {
            AuditDetailsClient auditClient = new AuditDetailsClient();
            var turnOverData = auditClient.GetTurnoverTypeData();
            TurnoverLists = new ObservableCollection<TurnoverModel>();
            foreach (var turnOver in turnOverData)
            {
                TurnoverModel turnOverValue = new TurnoverModel();
                turnOverValue.Id = turnOver.Id;
                turnOverValue.TurnoverType = turnOver.TurnOverType;
                turnOverValue.DateUpdated = turnOver.DateUpdated;
                TurnoverLists.Add(turnOverValue);
            }
        }
    }
}
