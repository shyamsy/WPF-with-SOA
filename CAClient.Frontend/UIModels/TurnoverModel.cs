using CAClient.Frontend.MvvmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Frontend.UIModels
{
    public class TurnoverModel : ViewModelBase
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string turnoverType;
        public string TurnoverType
        {
            get { return turnoverType; }
            set
            {
                turnoverType = value;
                OnPropertyChanged("TurnoverType");
            }
        }

        private DateTime dateUpdated;
        public DateTime DateUpdated
        {
            get { return dateUpdated; }
            set
            {
                dateUpdated = value;
                OnPropertyChanged("DateUpdated");
            }
        }
    }
}
