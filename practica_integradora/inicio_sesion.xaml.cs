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

namespace practica_integradora
{
    /// <summary>
    /// Lógica de interacción para inicio_sesion.xaml
    /// </summary>
    public partial class inicio_sesion : Window
    {
        public inicio_sesion()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            menu_principal V_menu_principal = new menu_principal();
            V_menu_principal.Show();
            this.Close();
        }
    }
}
