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

namespace UI
{
    /// <summary>
    /// Lógica de interacción para Agregar_serie.xaml
    /// </summary>
    public partial class Agregar_serie : Window
    {
        public Agregar_serie()
        {
            InitializeComponent();
        }

        private void salir_add_serie_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
