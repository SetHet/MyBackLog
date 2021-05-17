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
    /// Lógica de interacción para Agregar_contenido.xaml
    /// </summary>
    public partial class Agregar_contenido : Window
    {
        public Agregar_contenido()
        {
            InitializeComponent();
        }

        private void agregar_subtipo_Click(object sender, RoutedEventArgs e)
        {
            int indice = subtipo_add_cbo.SelectedIndex;
            if (indice == 0)
            {
                Agregar_pelicula add_pelicula = new Agregar_pelicula();
                add_pelicula.Show();
            }
            if (indice == 1) 
            {
                Agregar_juego add_game = new Agregar_juego();
                add_game.Show();
            }
            if (indice == 2)
            {
                Agregar_serie add_serie = new Agregar_serie();
                add_serie.Show();
            }
            if (indice == 3)
            {
                Agregar_libro add_libro = new Agregar_libro();
                add_libro.Show();
            }
        }

        private void salir_add_Click(object sender, RoutedEventArgs e)
        {
            Modificar_contenido modicar = new Modificar_contenido();
            modicar.Show();
            this.Close();
        }
    }
}
