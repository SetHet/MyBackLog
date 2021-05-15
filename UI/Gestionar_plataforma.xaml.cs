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
    /// Lógica de interacción para new_gestionar_plataforma.xaml
    /// </summary>
    public partial class new_gestionar_plataforma : Window
    {
        public new_gestionar_plataforma()
        {
            InitializeComponent();           
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void addplataforma_Click(object sender, RoutedEventArgs e)
        {
            Agregar_plataforma add = new Agregar_plataforma();
            add.Show();
            this.Close();
        }

        private void editar_plataforma_Click(object sender, RoutedEventArgs e)
        {
            Editar_plataforma edit = new Editar_plataforma();
            edit.Show();
            this.Close();

        }

        private void eliminar_plataforma_Click(object sender, RoutedEventArgs e)
        {
            Eliminar_plataforma delete = new Eliminar_plataforma();
            delete.Show();
            this.Close();
        }

        private void agregar_plataforma_bd_Click(object sender, RoutedEventArgs e)
        {
            Negocio.Plataforma plataforma = new Negocio.Plataforma
            {
                Titulo = txt_titulo_add.Text,
                Descripcion = txt_descripcion_add.Text
            };
            if (Negocio.PlataformaController.insertarPlataforma(plataforma)){
                MessageBox.Show("Insertado con éxtio");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
