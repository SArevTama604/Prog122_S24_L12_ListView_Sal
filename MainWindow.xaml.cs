using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_S24_L12_ListView_Sal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///


    public partial class MainWindow : Window
    {

        //Observable Collection
ObservableCollection<string> names = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();


            // lbShowNames.ItemsSource = Data.names;

            Account transferFrom = new Account();
            Account transferTo = new Account();
            Account.TransferMoney(transferFrom, transferTo, 500);
            //// Attach the field from our static, Data.cs, class
            //lblBusinessName.Content = Data.BusinessName;
        }

        private void btnOpenNewWindow_Click(object sender, RoutedEventArgs e)
        {
            // How to open up our new window we created.
            // When you create a new window, you are creation a new instanced object to call
            MyNewWindow myNew = new MyNewWindow();

            // To open it you can call the .Show() method on our variable name
            myNew.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            Data.names.Add(name);


        }
    }
}