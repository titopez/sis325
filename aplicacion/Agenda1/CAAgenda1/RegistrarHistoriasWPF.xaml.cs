using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using CADAgenda1;
using CLNAgenda1;

namespace CAAgenda1
{
    /// <summary>
    /// Lógica de interacción para RegistrarHistoriasWPF.xaml
    /// </summary>
    public partial class RegistrarHistoriasWPF : Window
    {
        private String desc;
        private bool habilitar;
        private int prioridad;
        private int Horas;
        private HistoriasCLN hcln = new HistoriasCLN();
        private SprintsCLN scln = new SprintsCLN();
        private Proyecto p = new Proyecto();
        private ProyectosCLN pcln = new ProyectosCLN();
        Historia h = new Historia();

        public RegistrarHistoriasWPF()
        {
            InitializeComponent();
            hcln.ordenar();
        }

        Form2proyectoM fp = new Form2proyectoM();
       
        private void bRegistrar_Click(object sender, RoutedEventArgs e)
        {
            desc = tbDescripcion.Text;
            prioridad = int.Parse(cbPrioridad.Text);
            habilitar = chbHabilitar.IsChecked.Value;
            Horas = int.Parse(tbHoras.Text);
            p = pcln.getProyecto(tbnombrep.Text);
            h.Descripcion = desc;
            h.Prioridad = prioridad;
            h.Habilitado = habilitar;
            h.Proyecto_id = p.id;
            h.Cantidad_Horas = Horas;
            h.Sprint_id_Sprint = 1;
            hcln.crearHistoria(h);
            MessageBox.Show("Se hizo el registro de la Historia con exito!!");
            dgHistorias.ItemsSource = hcln.listar(p.id);
            hcln.ordenar();
            tbDescripcion.Clear();
            cbPrioridad.Text = "";
            tbHoras.Clear();
            chbHabilitar.IsChecked = false;
            
 
        }
        private void listarHistorias()
        {
            //dgHistorias.ItemsSource = hcln.listar();
            //dgHistorias.Columns[0].Visibility=0;
            p = pcln.getProyecto(tbnombrep.Text);
            dgHistorias.ItemsSource = hcln.listar(p.id);
            //dgHistorias.ItemsSource = hcln.ordenar();
        }

        private void bCancelar_Click(object sender, RoutedEventArgs e)
        {
            desc = tbDescripcion.Text;
            h = hcln.getHistoria(desc);
            p = pcln.getProyecto(tbnombrep.Text);
            h.id = int.Parse(tbIDH.Text);
            hcln.eliminarHistoria(h);
            MessageBox.Show("se elimino con exito");
            dgHistorias.ItemsSource = hcln.listar(p.id);
        }

        private void wRegistroHist_Loaded(object sender, RoutedEventArgs e)
        {
            tbDescripcion.Text=fp.getnombrep();
            dgHistorias.ItemsSource = hcln.ordenar();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            h.Descripcion = tbDescripcion.Text;
            h.Prioridad = int.Parse(cbPrioridad.Text);
            h.Habilitado = chbHabilitar.IsChecked.Value;
            h.Cantidad_Horas = int.Parse(tbHoras.Text);
            p = pcln.getProyecto(tbnombrep.Text);
            h.Sprint_id_Sprint = 1;
            h.Proyecto_id = p.id;
            h.id = int.Parse(tbIDH.Text);
            hcln.modificarHistoria(h);
            MessageBox.Show("se actualizo la historia");
            dgHistorias.ItemsSource = hcln.listar(p.id);
            tbDescripcion.Clear();
            cbPrioridad.Text = "";
            tbHoras.Clear();
            chbHabilitar.IsChecked= false;
        }
        private void dgHistorias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            RegistroTareas tareas = new RegistroTareas();
            if (chbHabilitar.IsChecked.Value == true)
            {
                tareas.tbproyecto.Text = tbnombrep.Text;
                tareas.tbHistoria.Text = tbDescripcion.Text;
                tareas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("la historia no se acepto en el primer sprint");
            }
        }

        private void wRegistroHist_Closed(object sender, EventArgs e)
        {
            FormProyecto principal = new FormProyecto();
            principal.Show();
            this.Hide();
        }

        private void dgHistorias_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void dgHistorias_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void dgHistorias_Drop(object sender, DragEventArgs e)
        {
            
        }

        private void tbIDH_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
