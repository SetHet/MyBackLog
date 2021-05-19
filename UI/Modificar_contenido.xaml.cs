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
        private List<Datos.Contenido> Contenidos;

        public Modificar_contenido()
        {
            InitializeComponent();
            Llenar();
        }

        private void Llenar()
        {
            info.Items.Clear();
            Contenidos = Negocio.ContenidoController.listarContenido();
            if (Contenidos !=null)
            {
                foreach (var item in Contenidos)
                {
                    info.Items.Add(item);
                }
            }
        }

       

        private void agregar_contenido_Click(object sender, RoutedEventArgs e)
        {
            Gestion_contenido ges = new Gestion_contenido();
            ges.Show();
            this.Close();
        }

        private void deletecontent_Click(object sender, RoutedEventArgs e)
        {
            int select = info.SelectedIndex;
            if (select == -1)
            {
                MessageBox.Show("Seleccione un contenido");
            }
            else
            {
                if (Negocio.ContenidoController.deleteContenido(Contenidos[select].Id_contenido))
                {
                    Console.WriteLine("Eliminar");
                }
            }

            Llenar();
        }

        private void modificar_contenido_Click(object sender, RoutedEventArgs e)
        {
            Editar_contenido editar = new Editar_contenido();
            editar.Show();
            this.Close();
        }
    }
}
