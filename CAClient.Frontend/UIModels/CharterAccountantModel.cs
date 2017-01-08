using CAClient.Frontend.MvvmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Frontend.UIModels
{
    public class CharterAccountantModel : ViewModelBase
    {
        private string cAName;
        public string CaName
        {
            get { return cAName; }
            set
            {
                cAName = value;
                OnPropertyChanged("CaName");
            }
        }
    }
}
