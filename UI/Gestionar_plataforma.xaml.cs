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
    /// Lógica de interacción para Gestionar_plataforma.xaml
    /// </summary>
    public partial class Gestionar_plataforma : Window
    {
        public Gestionar_plataforma()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Agregar_plataforma add_plataforma = new Agregar_plataforma();
            add_plataforma.Show();
            this.Close();
        }

        private void editplataforma_Click(object sender, RoutedEventArgs e)
        {
            Editar_plataforma editar_Plataforma = new Editar_plataforma();
            editar_Plataforma.Show();
            this.Close();
        }

        private void deleteplataforma_Click(object sender, RoutedEventArgs e)
        {
            Eliminar_plataforma delete = new Eliminar_plataforma();
            delete.Show();
            this.Close();
        }
    }
}