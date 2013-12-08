using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace WP_1
{
    public partial class SecondPage : PhoneApplicationPage
    {
        String[] EvaluationItem = {"2","2.5","3","3.5","4","4.5","5"};
        String EvaluationName = "Ocena";
        public SecondPage()
        {
            InitializeComponent();
            this.lpkEvaluation.ItemsSource = EvaluationItem;
        }
    }
}