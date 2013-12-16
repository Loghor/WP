using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace WP_2
{
    public partial class SecondPage : PhoneApplicationPage
    {
        public ModelEvaluation _model;
        private ApplicationBarIconButton buttonSave;

        public SecondPage()
        {
            InitializeComponent();
            _model = new ModelEvaluation()
            {
                EvaluationItems = new string[] { "2", "2.5", "3", "3.5", "4", "4.5", "5" }
            };
            InitAppBar();
            this.DataContext = _model;
        }

        // Function init AppBar, I can't use xaml method because then IsEnabled=null
        private void InitAppBar()
        {
            ApplicationBar appBar = new ApplicationBar();

            buttonSave = new ApplicationBarIconButton(new Uri("Images/save.png", UriKind.Relative));
            buttonSave.Click += new EventHandler(buttonSave_OnClick);
            buttonSave.Text = "Save";
            buttonSave.IsEnabled = false;
            appBar.Buttons.Add(buttonSave);

            ApplicationBar = appBar;
        }

        private void buttonSave_OnClick(object sender, EventArgs e)
        {
            EvaluationSingleton.Instance.AddItems(textBoxName.Text, textBoxSurname.Text, lpkEvaluation.SelectedItem.ToString());
            NavigationService.GoBack();
            //throw new NotImplementedException();
        }

        private void textBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBoxName.Text == "" && textBoxSurname.Text == "")
                buttonSave.IsEnabled = false;
            else
                buttonSave.IsEnabled = true;
        }

        private void textBoxSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBoxName.Text == "" && textBoxSurname.Text == "")
                buttonSave.IsEnabled = false;
            else
                buttonSave.IsEnabled = true;
        }
    }
}