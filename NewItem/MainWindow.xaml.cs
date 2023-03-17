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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewItem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\m.yovchevski\source\repos\NewItem\NewItem\Database1.mdf;Integrated Security=True;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            NewItem.SignUpDBDataSet signUpDBDataSet = ((NewItem.SignUpDBDataSet)(this.FindResource("signUpDBDataSet")));
            // Load data into the table SignupTable_. You can modify this code as needed.
            NewItem.SignUpDBDataSetTableAdapters.SignupTable_TableAdapter signUpDBDataSetSignupTable_TableAdapter = new NewItem.SignUpDBDataSetTableAdapters.SignupTable_TableAdapter();
            signUpDBDataSetSignupTable_TableAdapter.Fill(signUpDBDataSet.SignupTable_);
            System.Windows.Data.CollectionViewSource signupTable_ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("signupTable_ViewSource")));
            signupTable_ViewSource.View.MoveCurrentToFirst();
        }

        private void firstNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(firstNameComboBox.SelectedIndex == firstNameComboBox.Items.Count - 1)
            {
                MainWindow mw = new MainWindow();
                mw.Show();
            }
        }
    }
}
