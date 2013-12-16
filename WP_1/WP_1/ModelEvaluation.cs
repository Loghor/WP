using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_1
{
    public class ModelEvaluation : INotifyPropertyChanged
    {
        private string[] _evaluationItems;

        public string[] EvaluationItems
        {
            get
            {
                return _evaluationItems;
            }

            set
            {
                if (value == _evaluationItems)
                    return;
                _evaluationItems = value;
                OnPropertyChanged("EvaluationItems");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
