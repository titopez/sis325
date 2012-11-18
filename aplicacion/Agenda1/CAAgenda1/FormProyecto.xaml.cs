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
using CADAgenda1;
using CLNAgenda1;
namespace CAAgenda1
{
    /// <summary>
    /// Lógica de interacción para FormProyecto.xaml
    /// </summary>
    public partial class FormProyecto : Window
    {
        private ProyectosCLN pcln = new ProyectosCLN();
        Proyecto proy = new Proyecto();
        public FormProyecto()
        {
            InitializeComponent();
            mostrar();
        }
        private void mostrar()
        {
            cbelegirproyecto.DisplayMemberPath = "Nombre";
            cbelegirproyecto.ItemsSource = pcln.listar();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Form2proyectoM nuevo = new Form2proyectoM();
            if (cbelegirproyecto.Text == "")
            {
                MessageBox.Show("Por favor seleccione un proyecto!!");
            }
            else
            {
                int id = pcln.getProyecto(cbelegirproyecto.Text).id;
                string Nombre = pcln.getProyecto(cbelegirproyecto.Text).Nombre;
                DateTime fechainicio = pcln.getProyecto(cbelegirproyecto.Text).FechaInicio;
                DateTime fechafinal = pcln.getProyecto(cbelegirproyecto.Text).FechaFinalizacion;
                string objetivo = pcln.getProyecto(cbelegirproyecto.Text).Objetivo;
                int cajatiempo = pcln.getProyecto(cbelegirproyecto.Text).CajaTiempo;
                string necesidad = pcln.getProyecto(cbelegirproyecto.Text).Necesidad;

                nuevo.tbID.Text = id.ToString();
                nuevo.tbNuevoProy.Text = Nombre;
                nuevo.dpFechaIni.Text = fechainicio.ToString();
                nuevo.dpFechaFin.Text = fechafinal.ToString();
                nuevo.tbObjetivo.Text = objetivo;
                nuevo.tbCajatiempo.Text = cajatiempo.ToString();
                nuevo.tbNecedidad.Text = necesidad;
                nuevo.Show();
                this.Hide();
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            (new NuevoProyectoWPF()).Show();
            this.Hide();
        }
    }
}
