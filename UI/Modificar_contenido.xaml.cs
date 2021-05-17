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
    /// Lógica de interacción para Modificar_contenido.xaml
    /// </summary>
    public partial class Modificar_contenido : Window
    {
        public Modificar_contenido()
        {
            InitializeComponent();
        }

        private void addplataforma_Click(object sender, RoutedEventArgs e)
        {
            Editar_contenido editar = new Editar_contenido();
            editar.Show();
            this.Close();
        }

        private void agregar_contenido_Click(object sender, RoutedEventArgs e)
        {
            Agregar_contenido agregar = new Agregar_contenido();
            agregar.Show();
            this.Close();
        }
    }
}
