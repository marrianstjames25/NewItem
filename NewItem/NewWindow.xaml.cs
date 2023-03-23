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

namespace NewItem
{
    /// <summary>
    /// Interaction logic for NewWindow.xaml
    /// </summary>
    public partial class NewWindow : Window
    {
        public NewWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            NewItem.LibrarySystemDataSet librarySystemDataSet = ((NewItem.LibrarySystemDataSet)(this.FindResource("librarySystemDataSet")));
            // Load data into the table Borrower_Details. You can modify this code as needed.
            NewItem.LibrarySystemDataSetTableAdapters.Borrower_DetailsTableAdapter librarySystemDataSetBorrower_DetailsTableAdapter = new NewItem.LibrarySystemDataSetTableAdapters.Borrower_DetailsTableAdapter();
            librarySystemDataSetBorrower_DetailsTableAdapter.Fill(librarySystemDataSet.Borrower_Details);
            System.Windows.Data.CollectionViewSource borrower_DetailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("borrower_DetailsViewSource")));
            borrower_DetailsViewSource.View.MoveCurrentToFirst();
        }

        private void borrower_DetailsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
