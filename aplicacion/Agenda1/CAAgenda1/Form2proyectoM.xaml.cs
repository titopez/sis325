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
using CLNAgenda1;
using CADAgenda1;

namespace CAAgenda1
{
    /// <summary>
    /// Lógica de interacción para Form2proyectoM.xaml
    /// </summary>
    public partial class Form2proyectoM : Window
    {
        string nombre_proyecto;
        private ProyectosCLN pcln = new ProyectosCLN();
        private Proyecto proyecto = new Proyecto();
        private int idProy;
        public Form2proyectoM(int id)
        {
            InitializeComponent();
            idProy = id;
        }

        private void bCancelar_Click(object sender, RoutedEventArgs e)
        {
            (new FormProyecto()).Show();
            this.Hide();
        }
        public string getnombrep()
        {
            nombre_proyecto = tbNuevoProy.Text;
            return nombre_proyecto;
        }
        private void bCrearHistoria_Click(object sender, RoutedEventArgs e)
        {
            RegistrarHistoriasWPF rh =new RegistrarHistoriasWPF(idProy);
            rh.Show();
            //rh.tbnombrep.Text = this.getnombrep();
            this.Hide();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        { 
            proyecto.Nombre = tbNuevoProy.Text;
            proyecto.FechaInicio = DateTime.Parse(dpFechaIni.Text);
            proyecto.FechaFinalizacion = DateTime.Parse(dpFechaFin.Text);
            proyecto.CajaTiempo = int.Parse(tbCajatiempo.Text);
            proyecto.Objetivo = tbObjetivo.Text;
            proyecto.Necesidad = tbNecedidad.Text;
            proyecto.id = int.Parse(tbID.Text);
            pcln.modificarProyecto(proyecto);
            MessageBox.Show("se modifico el Proyecto");
            button1.IsEnabled = false;
        }

        private void bEqScrum_Click(object sender, RoutedEventArgs e)
        {
            CrearRolWPF rolwpf = new CrearRolWPF(idProy);
            rolwpf.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbID.Text = pcln.getProyectoId(idProy).id.ToString();
            tbNuevoProy.Text = pcln.getProyectoId(idProy).Nombre;
            dpFechaIni.Text = pcln.getProyectoId(idProy).FechaInicio.ToString();
            dpFechaFin.Text = pcln.getProyectoId(idProy).FechaFinalizacion.ToString();
            tbObjetivo.Text = pcln.getProyectoId(idProy).Objetivo;
            tbCajatiempo.Text = pcln.getProyectoId(idProy).CajaTiempo.ToString();
            tbNecedidad.Text = pcln.getProyectoId(idProy).Necesidad.ToString();
        }

    }
}
