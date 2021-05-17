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
    /// Lógica de interacción para Editar_progresion.xaml
    /// </summary>
    public partial class Editar_progresion : Window
    {
        public Editar_progresion()
        {
            InitializeComponent();
        }

        private void salir_edit_progresion_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
