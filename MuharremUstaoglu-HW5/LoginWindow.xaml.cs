
using MuharremUstaoglu_HW5.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MuharremUstaoglu_HW5.MData;


namespace MuharremUstaoglu_HW5
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        UserRole userRole = new UserRole();
        UserRole userRole2 = new UserRole();
        UserRole userRole3 = new UserRole();
        public LoginWindow()
        {
            userRole.RoleId = 1;
            userRole.RoleName = "Admin";

            userRole2.RoleId = 2;
            userRole2.RoleName = "Student";

            userRole3.RoleId = 3;
            userRole3.RoleName = "Instructor";



            InitializeComponent();
        }
       
        
        
        

        
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            CetUserService cetUserService = new CetUserService();
            //txtPassword.Text=cetUserService.hashPassword("admin");
            var loginUser = cetUserService.Login(txtUserName.Text, txtPassword.Password);
            if (loginUser == null)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            else
            {
                /// Doğru giriş yapıldı.
                MainWindow mainWindow = new MainWindow(loginUser);
                mainWindow.Show();
                this.Close();
            }
        }
    }
}
