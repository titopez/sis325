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
    /// Lógica de interacción para NuevoProyectoWPF.xaml
    /// </summary>
    public partial class NuevoProyectoWPF : Window
    {
        private String nombre;
        private DateTime fechaIni;
        private DateTime fechaFin;
        private String objetivo;
        private int caja_tiempo;
        private String Necesidad;
        ProyectosCLN pcln = new ProyectosCLN();
        
        public NuevoProyectoWPF()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void bCrearProy_Click(object sender, RoutedEventArgs e)
        {
            nombre = tbNuevoProy.Text;
            fechaIni = DateTime.Parse(dpFechaIni.SelectedDate.ToString());
            fechaFin = DateTime.Parse(dpFechaFin.SelectedDate.ToString());
            objetivo = tbObjetivo.Text;
            caja_tiempo = int.Parse(tbCajatiempo.Text);
            Necesidad = tbNecedidad.Text;
            Proyecto p = new Proyecto();
            p.Nombre = nombre;
            p.FechaInicio = fechaIni;
            p.FechaFinalizacion = fechaFin;
            p.Objetivo = objetivo;
            p.CajaTiempo = caja_tiempo;
            p.Necesidad = Necesidad;
            pcln.crearProyecto(p);
            MessageBox.Show("El Proyecto " + nombre + " fue Registrado con Exito!!!");
            limpiar();
        }

        private void bCancelar_Click(object sender, RoutedEventArgs e)
        {
            (new FormProyecto()).Show();
            this.Hide();
        }
        private void limpiar()
        {
            tbNuevoProy.Clear();
            tbObjetivo.Clear();
            tbCajatiempo.Clear();
            tbNecedidad.Clear();
        }
    }
}
