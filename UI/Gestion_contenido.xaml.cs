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
    /// Lógica de interacción para Gestion_contenido.xaml
    /// </summary>
    public partial class Gestion_contenido : Window
    {
        public Gestion_contenido()
        {
            InitializeComponent();
        }

        private void salir_editar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void editar_subtipo_Click(object sender, RoutedEventArgs e)
        {
            int indice = subtipo_cbo.SelectedIndex;
            if (indice == 0)
            {
                pelicula_grid.Visibility = Visibility.Visible;
                grid_juego.Visibility = Visibility.Collapsed;
                grid_serie.Visibility = Visibility.Collapsed;
                grid_libro.Visibility = Visibility.Collapsed;
            }
            if (indice == 1)
            {
                pelicula_grid.Visibility = Visibility.Collapsed;
                grid_juego.Visibility = Visibility.Visible;
                grid_serie.Visibility = Visibility.Collapsed;
                grid_libro.Visibility = Visibility.Collapsed;
            }
            if (indice == 2)
            {
                pelicula_grid.Visibility = Visibility.Collapsed;
                grid_juego.Visibility = Visibility.Collapsed;
                grid_serie.Visibility = Visibility.Visible;
                grid_libro.Visibility = Visibility.Collapsed;
            }
            if (indice == 3)
            {
                pelicula_grid.Visibility = Visibility.Collapsed;
                grid_juego.Visibility = Visibility.Collapsed;
                grid_serie.Visibility = Visibility.Collapsed;
                grid_libro.Visibility = Visibility.Visible;
            }
        }
    }
}
