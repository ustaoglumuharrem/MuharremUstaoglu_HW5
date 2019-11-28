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
using MuharremUstaoglu_HW5.MData;

namespace MuharremUstaoglu_HW5
{
    public partial class MainWindow : Window
    {
       



        private CetUser loginUser;

        public MainWindow(CetUser cetUser)
        {
            
            InitializeComponent();
            loginUser = cetUser;
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            txtDisplay.Text = "Merhaba " + loginUser.Name + " " + loginUser.Surname + " " +loginUser.Role;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin misiniz?", "Onay", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void ŞifreDegistirClick(object sender, RoutedEventArgs e)
        {
            changepassword changepassword = new changepassword(loginUser);
            changepassword.Show();
        }
    }
}
