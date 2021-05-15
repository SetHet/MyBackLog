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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grid_agregar.Visibility = Visibility.Visible;
            grid_principal.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
        }

        private void Cancelar_plataforma_add_Click(object sender, RoutedEventArgs e)
        {
            grid_agregar.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Visible;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;

            txt_titulo_add.Clear();
            txt_descripcion_add.Clear();
        }

        private void cancelar_editar_Click(object sender, RoutedEventArgs e)
        {
            grid_agregar.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Visible;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;

            txt_codigo_edit.Clear();
            txt_titulo_edit.Clear();
            txt_descripcion_edit.Clear();
        }

        private void editplataforma_Click(object sender, RoutedEventArgs e)
        {
            edit_grid.Visibility = Visibility.Visible;
            grid_agregar.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
        }

        private void salirver_Click(object sender, RoutedEventArgs e)
        {
            grid_principal.Visibility = Visibility.Visible;
            grid_agregar.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
        }

        private void verplataforma_Click(object sender, RoutedEventArgs e)
        {
            grid_principal.Visibility = Visibility.Collapsed;
            grid_agregar.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Visible;
            delete_grid.Visibility = Visibility.Collapsed;
        }

        private void cancelar_delete_Click(object sender, RoutedEventArgs e)
        {
            grid_principal.Visibility = Visibility.Visible;
            grid_agregar.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;

            txt_codigo_delete.Clear();
        }

        private void deleteplataforma_Click(object sender, RoutedEventArgs e)
        {
            grid_principal.Visibility = Visibility.Collapsed;
            grid_agregar.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Visible;
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
