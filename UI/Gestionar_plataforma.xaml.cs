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

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void cancelar_pelicula_add_click(object sender, RoutedEventArgs e)
        {
            grid_peliculas.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            grid_agregar.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            grid_btnplus.Visibility = Visibility.Visible;
            delete_grid.Visibility = Visibility.Collapsed;
            
           
           txt_descripcionpel_add.Clear();
           txt_titulopel_add.Clear();
           txt_calificacion_add.Clear();
           txt_horasinversion_add.Clear();
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            
            grid_agregar.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
            grid_peliculas.Visibility = Visibility.Collapsed;
            grid_btnplus.Visibility = Visibility.Visible;
        }

        private void btn_plus_add(object sender, RoutedEventArgs e)
        {
            grid_agregar.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
            grid_peliculas.Visibility = Visibility.Visible;
            grid_btnplus.Visibility = Visibility.Collapsed;
        }

        private void btn_plus_add_serie(object sender, RoutedEventArgs e)
        {
            grid_agregar.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
            grid_peliculas.Visibility = Visibility.Collapsed;
            grid_btnplus.Visibility = Visibility.Collapsed;
            grid_btnplus_serie.Visibility = Visibility.Collapsed;
            grid_btnplus_juego.Visibility = Visibility.Collapsed;
            grid_series.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            grid_agregar.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
            grid_peliculas.Visibility = Visibility.Collapsed;
            grid_btnplus_serie.Visibility = Visibility.Visible;
        }

        private void cancelar_serie_add_click(object sender, RoutedEventArgs e)
        {
            grid_peliculas.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            grid_agregar.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            grid_btnplus.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
            grid_series.Visibility = Visibility.Collapsed;
            grid_btnplus_serie.Visibility = Visibility.Visible;



            txt_descripcionserie_add.Clear();
            txt_tituloserie_add.Clear();
            txt_calificacionserie_add.Clear();
            txt_horasinversionserie_add.Clear();
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            grid_agregar.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
            grid_peliculas.Visibility = Visibility.Collapsed;
            grid_btnplus_serie.Visibility = Visibility.Collapsed;
            grid_btnplus_juego.Visibility = Visibility.Visible;
        }

        
        private void cancelar_game_add_click(object sender, RoutedEventArgs e)
        {
            grid_peliculas.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            grid_agregar.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            grid_btnplus.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
            grid_series.Visibility = Visibility.Collapsed;
            grid_juegos.Visibility = Visibility.Collapsed;
            grid_btnplus_serie.Visibility = Visibility.Collapsed;
            grid_btnplus_juego.Visibility = Visibility.Visible;



            txt_descripciongame_add.Clear();
            txt_titulogame_add.Clear();
            txt_calificacion_game.Clear();
            txt_horasinversion_game.Clear();
        }
        

        private void btn_plus_add_game_Click(object sender, RoutedEventArgs e)
        {
            grid_agregar.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
            grid_peliculas.Visibility = Visibility.Collapsed;
            grid_btnplus.Visibility = Visibility.Collapsed;
            grid_btnplus_serie.Visibility = Visibility.Collapsed;
            grid_btnplus_juego.Visibility = Visibility.Collapsed;
            grid_series.Visibility = Visibility.Collapsed;
            grid_juegos.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected_4(object sender, RoutedEventArgs e)
        {
            grid_agregar.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
            grid_peliculas.Visibility = Visibility.Collapsed;
            grid_btnplus_serie.Visibility = Visibility.Collapsed;
            grid_btnplus_juego.Visibility = Visibility.Collapsed;
            grid_btnplus_libro.Visibility = Visibility.Visible;
        }

        private void cancelar_libro_add_click(object sender, RoutedEventArgs e)
        {
            grid_peliculas.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            grid_agregar.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            grid_btnplus.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
            grid_series.Visibility = Visibility.Collapsed;
            grid_juegos.Visibility = Visibility.Collapsed;
            grid_libros.Visibility = Visibility.Collapsed;
            grid_btnplus_serie.Visibility = Visibility.Collapsed;
            grid_btnplus_juego.Visibility = Visibility.Collapsed;
            grid_btnplus_libro.Visibility = Visibility.Visible;



            txt_descripcionlibro_add.Clear();
            txt_titulolibro_add.Clear();
            txt_calificacionlibro_add.Clear();
            txt_horasinversionlibro_add.Clear();
        }

        private void btn_plus_add_libro(object sender, RoutedEventArgs e)
        {
            grid_agregar.Visibility = Visibility.Collapsed;
            grid_principal.Visibility = Visibility.Collapsed;
            edit_grid.Visibility = Visibility.Collapsed;
            grid_ver.Visibility = Visibility.Collapsed;
            delete_grid.Visibility = Visibility.Collapsed;
            grid_peliculas.Visibility = Visibility.Collapsed;
            grid_btnplus.Visibility = Visibility.Collapsed;
            grid_btnplus_serie.Visibility = Visibility.Collapsed;
            grid_btnplus_juego.Visibility = Visibility.Collapsed;
            grid_btnplus_libro.Visibility = Visibility.Collapsed;
            grid_series.Visibility = Visibility.Collapsed;
            grid_juegos.Visibility = Visibility.Collapsed;
            grid_libros.Visibility = Visibility.Visible;
        }
        private void btniconaddser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btniconaddgame_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}


/*< Button x: Name = "IrPeliculas" Content = "Pelicula" Height = "45" VerticalAlignment = "Center" Background = "{x:Null}" BorderBrush = "{x:Null}" Click = "Button_Click_1" Width = "50" >
</ Button >*/