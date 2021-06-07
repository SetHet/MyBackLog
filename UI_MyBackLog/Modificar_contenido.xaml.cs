﻿using Datos;
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
    /// Lógica de interacción para Modificar_contenido.xaml
    /// </summary>
    public partial class Modificar_contenido : Window
    {
        private List<Contenido> contenidos;
        public List<Plataforma> lista_plataformas;
        public string filtroB = "";


        public Modificar_contenido()
        {
            InitializeComponent();
            Llenar();
            LlenarPlat();
        }

        private void Llenar()
        {
            info.Items.Clear();
            contenidos = Negocio.ContenidoController.listarContenido();

            //Filtros B
            if (filtroB == "Viendo")
            {
                List<Contenido> cont2 = new List<Contenido>();
                foreach (var cont in contenidos)
                {
                    if (cont.Id_progresion == 2)
                    {
                        cont2.Add(cont);
                    }
                }
                contenidos = cont2;
            }
            else if (filtroB == "Pendientes")
            {
                List<Contenido> cont2 = new List<Contenido>();
                foreach (var cont in contenidos)
                {
                    if (cont.Id_progresion == 0)
                    {
                        cont2.Add(cont);
                    }
                }
                contenidos = cont2;
            }
            else if (filtroB == "Sugerencias")
            {
                contenidos.Sort((b, a) => ((a.Calificacion / (float)a.Horas_inversion).CompareTo(b.Calificacion / (float)b.Horas_inversion)));
            }
            


            //


            if (contenidos !=null)
            {
                foreach (var item in contenidos)
                {
                    info.Items.Add(item);
                }
            }
        }
        private void LlenarPlat()
        {
            lista_plataformas = PlataformaController.listaPlataformas();
            if (lista_plataformas != null) 
            {
                foreach (var item in lista_plataformas)
                {
                    cboPlatFiltro.Items.Add(item.Titulo);
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
                if (Negocio.ContenidoController.deleteContenido(contenidos[select].Id_contenido))
                {
                    Console.WriteLine("Eliminar");
                }
            }

            Llenar();
        }

        private void modificar_contenido_Click(object sender, RoutedEventArgs e)
        {
            int select = info.SelectedIndex;
            if (select == -1)
            {
                MessageBox.Show("Se debe seleccionar un contenido", "Aviso", MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }
            
            Gestion_contenido editar = new Gestion_contenido(contenidos[select].Id_contenido);
            editar.Show();
            this.Close();
        }

        private void plat_Selected(object sender, RoutedEventArgs e)
        {
            Gestionar_plataforma gestionar = new Gestionar_plataforma();
            gestionar.Show();
            this.Close();
        }

        private void filtrado_Click(object sender, RoutedEventArgs e)
        {
            int id_cat = cboCatFiltro.SelectedIndex;
            int plat = 0;
            if (cboPlatFiltro.SelectedIndex > 0) 
            {
                plat = lista_plataformas[cboPlatFiltro.SelectedIndex-1].Id_plataforma;
            }
            int cali = cboEstFiltro.SelectedIndex;
            if (id_cat > 0)
            {
                string table = cboCatFiltro.Text;
                Filtrado(plat, cali, table);
            }
            else 
            {
                Filtrado(plat, cali);
            }
        }
        private void Filtrado(int id_plataforma, int id_calificacion, string tabla = null){
            string where = "";
            if (id_plataforma != 0 || id_calificacion != 0 || tabla != null)
            {
                info.Items.Clear();
                contenidos = null;
                Console.WriteLine(id_plataforma);
                Console.WriteLine(id_calificacion);
                Console.WriteLine(tabla);

                if (id_calificacion > 0 && id_plataforma == 0)
                {
                    where = $" where calificacion = {id_calificacion}";
                }
                else if (id_plataforma > 0 && id_calificacion == 0)   
                {
                    where = $" where id_plataforma = {id_plataforma}";
                }
                else if(id_plataforma > 0 && id_calificacion > 0)
                {
                    where = $" where  calificacion = {id_calificacion} and id_plataforma = {id_plataforma}";
                }
                if (tabla != "") 
                {
                    contenidos = ContenidoController.Filtro(where, tabla);
                }
                else
                {
                    contenidos = ContenidoController.Filtro(where);

                }
                if (contenidos != null)
                {
                    foreach (var item in contenidos)
                    {
                        info.Items.Add(item);
                    }
                }
            }
            else
            {
                filtroB = "";
                Llenar();
            }
        }

       
        private void Nav_QueEstoyViendo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            filtroB = "Viendo";
            Llenar();
        }

        private void Nav_Sugerencias_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            filtroB = "Sugerencias";
            Llenar();
        }

        private void Nav_Pendiente_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            filtroB = "Pendientes";
            Llenar();
        }

        private void Nav_Peliculas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            filtroB = "";
            Filtrado(0, 0, "Pelicula");
        }

        private void Nav_Serie_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            filtroB = "";
            Filtrado(0, 0, "Serie");
        }

        private void Nav_Juego_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            filtroB = "";
            Filtrado(0, 0, "Juego");
        }

        private void Nav_Libro_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            filtroB = "";
            Filtrado(0, 0, "Libro");
        }
    }
}