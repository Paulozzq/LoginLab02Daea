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

namespace Login
{
    /// <summary>
    /// Lógica de interacción para loginPage.xaml
    /// </summary>
    public partial class loginPage : Window
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Password;

            if (usuario == "admin" && password == "1234")
            {
                homePage menu = new homePage();
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
