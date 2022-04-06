using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Myfirstapp
{
    /// <summary>
    /// Interaction logic for CreateNewDateWindow.xaml
    /// </summary>
    public partial class CreateNewDateWindow : Window
    {
        public CreateNewDateWindow()
        {
            InitializeComponent();
        }
                
        private void Name_Clicked(object sender, RoutedEventArgs e)
        {
            Name.Text = "";
        }

        private void ConfirmClicked(object sender, RoutedEventArgs e)
        {           
            
            string name = "";
            DateTime chosenDate = new DateTime(2000, 01, 01);
            bool nameValidated = false;
            bool dateValidated = false;

            if (Name.Text != null && Name.Text != "Name" && Name.Text.Length > 1){
                name = Name.Text;
                nameValidated = true;
            }
            else
            {
                MessageBox.Show("Please enter a name!");
                
            }

            
            
            if (ChosenDate.SelectedDate != null)
            {
                chosenDate = (DateTime)ChosenDate.SelectedDate;
                dateValidated = true;
            }

            //check if this is an event
            bool isEvent = false;

            if (EventCheckBox.IsChecked == true)
            {
                isEvent = true;
            }
            
            if (dateValidated && nameValidated)
            {
                MyFirstWPFApp.MainWindow.AddNewDateToList(name, chosenDate, isEvent);
                Close();
            }
            
        }
    }
}
