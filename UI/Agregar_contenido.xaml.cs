using Datos;
using Negocio;
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
        private List<Progresion> Progresion;
        private List<string> Progresion_mostrar;
        private List<Adquisicion> Adquisicion;
        private List<string> Adquisicion_mostrar;
        private List<Plataforma> Plataformas;
        private List<string> Plataforma_mostra;
        
        public Agregar_contenido()
        {
            InitializeComponent();
            listarProgesion();
            ListarAdquisicion();
            ListarPlataforma();
        }

        private void listarProgesion()
        {
            Progresion = ProgresionController.listarProgresiones();
            Progresion_mostrar = new List<string>();
            foreach (var item in Progresion)
            {
                string mostrar = item.Nombre_estado + ": " + item.Descripcion;
                Progresion_mostrar.Add(mostrar);
            }
            cboProg.ItemsSource = Progresion_mostrar;
        }

        private void ListarAdquisicion()
        {
            Adquisicion = AdquisicionController.listaAdquisiciones();
            Adquisicion_mostrar = new List<string>();
            foreach (var item in Adquisicion)
            {
                Adquisicion_mostrar.Add(item.Nombre_adquision);
            }
            cboAdquisicion.ItemsSource = Adquisicion_mostrar;
        }

        private void ListarPlataforma()
        {
            Plataformas = PlataformaController.listaPlataformas();
            Plataforma_mostra = new List<string>();
            foreach (var item in Plataformas)
            {
                Plataforma_mostra.Add(item.Titulo);
            }
            cboPlataforma.ItemsSource = Plataforma_mostra;
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

        private void aceptar_add_Click(object sender, RoutedEventArgs e)
        {
            int idAd = Adquisicion[cboAdquisicion.SelectedIndex].Id_adquisicion;
            int idPla = Plataformas[cboPlataforma.SelectedIndex].Id_plataforma;
            int idPro = Progresion[cboProg.SelectedIndex].Id_progresion;
            int idCont = subtipo_add_cbo.SelectedIndex +1;
            Contenido contenido = new Contenido
            {
                Titulo = txtTitulo.Text,
                Descripcion = txtDesc.Text,
                Horas_inversion = int.Parse(txtHrs.Text),
                Calificacion = int.Parse(txtCali.Text.ToString()), 
                Id_adquisicion = idAd,
                Id_plataforma = idPla,
                Id_progresion = idPro, 
                Id_contenido = idCont
            };
            if (ContenidoController.insertContenido(contenido))
            {
                MessageBox.Show("Añadido con éxito");             
            }
            else
            {
                MessageBox.Show("Error al añadir");
            }

        }
    }
}
