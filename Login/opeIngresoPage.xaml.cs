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
    /// Lógica de interacción para opeIngresoPage.xaml
    /// </summary>
    public partial class opeIngresoPage : Window
    {
        public opeIngresoPage()
        {
            InitializeComponent();
        }

        private void irHome(object sender, RoutedEventArgs e)
        {
            homePage menu = new homePage();
            menu.Show();
            this.Close();
        }
    }
}
