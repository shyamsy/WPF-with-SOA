using CAClient.Frontend.MvvmBase;
using CAClient.Frontend.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Frontend.Configurations
{
    public class AddCAViewModel : ViewModelBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public CharterAccountantModel charAccountModel;
        public CharterAccountantModel CharterAccModel
        {
            get { return CharterAccModel; }
            set
            {
                charAccountModel = value;
                OnPropertyChanged("CharterAccModel");
            }
        }
        public AddCAViewModel()
        {
            CharterAccModel = new CharterAccountantModel();
        }
    }
}
