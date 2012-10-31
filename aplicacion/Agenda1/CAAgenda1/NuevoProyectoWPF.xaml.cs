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
        
        public NuevoProyectoWPF()
        {
            InitializeComponent();
        }

        private void bCrearProy_Click(object sender, RoutedEventArgs e)
        {
            nombre = tbNuevoProy.Text;
            fechaIni = DateTime.Parse(dpFechaIni.SelectedDate.ToString());
            fechaFin = DateTime.Parse(dpFechaIni.SelectedDate.ToString());
            objetivo = tblObjetivoProy.Text;
        }
    }
}
