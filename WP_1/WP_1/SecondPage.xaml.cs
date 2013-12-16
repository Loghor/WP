using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Data;
using System.ComponentModel;

namespace WP_1
{
    public partial class SecondPage : PhoneApplicationPage
    {
        public ModelEvaluation _model;

        public SecondPage()
        {
            InitializeComponent();
            _model = new ModelEvaluation()
            {
                EvaluationItems = new string[]{"2","2.5","3","3.5","4","4.5","5"}
            };

            this.DataContext = _model;
        }
    }
}