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
    /// Lógica de interacción para Editar_contenido.xaml
    /// </summary>
    public partial class Editar_contenido : Window
    {
        public Editar_contenido()
        {
            InitializeComponent();
        }

        private void salir_editar_Click(object sender, RoutedEventArgs e)
        {
            Modificar_contenido modificar = new Modificar_contenido();
            modificar.Show();
            this.Close();
        }

        private void editar_subtipo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
