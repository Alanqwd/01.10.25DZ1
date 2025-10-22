using _1._10._25Dz;
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

namespace _01._10._25DZ1
{
    /// <summary>
    /// Логика взаимодействия для Case.xaml
    /// </summary>
    public partial class Case : Window
    {
        public Case()
        {
            InitializeComponent();
        }

        private void SaveCase(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            string case_name = titleToDo.Text;
            DateTime? date_case = dateToDo.SelectedDate;
            string case_description = descriptionToDo.Text;
            string case_title = titleToDo.Text;

            if (this.Owner is MainWindow main)
            {

                main.CasesList.Add(new ToDo(case_name, date_case, case_description, case_title));

                titleToDo.Text = null;
                dateToDo.SelectedDate = null;
                descriptionToDo.Text = null;

                main.UpdateList();
                this.Close();
            }
        }
    }
}


