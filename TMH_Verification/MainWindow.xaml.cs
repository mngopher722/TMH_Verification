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
using MahApps.Metro.Controls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TMH_Verification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationService ns = NavigationService.GetNavigationService(this);
        }
        void MenuButtonClick(object sender, RoutedEventArgs e)
        {

        }
        private void ToggleFlyoutSetting(object sender, RoutedEventArgs e)
        {
            flyout.IsOpen = !flyout.IsOpen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addClient_Click(object sender, RoutedEventArgs e)
        {
            AddClientPage AddClient = new AddClientPage();
            
            //this.Frame.Navigate(typeof(AddClient), null);
        }
        private void home_Click(object sender, RoutedEventArgs e)
        {
            //this.addClient_Click.Show
        }
        private void addJob_Click(object sender, RoutedEventArgs e)
        {
            //this.addClient_Click.Show
        }
        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            //this.addClient_Click.Show
        }
        private void configure_Click(object sender, RoutedEventArgs e)
        {
            //this.addClient_Click.Show
        }
        private void reports_Click(object sender, RoutedEventArgs e)
        {
            //this.addClient_Click.Show
        }
    }
}
