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
            int indice = subtipo_cbo.SelectedIndex;
            if(indice == 0)
            {
                Editar_pelicula edpe = new Editar_pelicula();
                edpe.Show();
            }
            if (indice == 1)
            {
                Editar_juego edju = new Editar_juego();
                edju.Show();
            }
            if (indice == 2)
            {
                Editar_serie edse = new Editar_serie();
                edse.Show();
            }
            if (indice == 3)
            {
                Editar_libro edli = new Editar_libro();
                edli.Show();
            }
            
        }
    }
}
