using MuharremUstaoglu_HW5.MData;
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

namespace MuharremUstaoglu_HW5
{
    /// <summary>
    /// Interaction logic for changepassword.xaml
    /// </summary>
    public partial class changepassword : Window
    {
        private CetUser loginUser;
        private LibraryDb Database = new LibraryDb();



        public changepassword(CetUser cetUser)
        {
            loginUser = cetUser;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CetUserService cetUserService = new CetUserService();

            string tempeskisifre = cetUserService.hashPassword(txtold.Password.ToString());

            if (tempeskisifre == loginUser.Password)
            {
                string tempyenisifre = cetUserService.hashPassword(txtnew.Password.ToString());
                string tempyenisifretekrar = cetUserService.hashPassword(txtnewagain.Password.ToString());
                if (tempyenisifre == tempyenisifretekrar)
                {
                    loginUser.Password = tempyenisifre;
                    Database.CetUsers.Update(loginUser);
                    Database.SaveChangesAsync();
                    MessageBox.Show("Şifreniz  değiştirildi.");
                }
                else MessageBox.Show("Hatalı Giriş");
            }
            else MessageBox.Show("Hatalı Giriş");






        }
    }
}
