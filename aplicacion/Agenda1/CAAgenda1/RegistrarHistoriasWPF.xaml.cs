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
    /// Lógica de interacción para RegistrarHistoriasWPF.xaml
    /// </summary>
    public partial class RegistrarHistoriasWPF : Window
    {
        private String desc;
        private bool habilitar;
        private int prioridad;
        private String nombrep;
        private HistoriasCLN hcln = new HistoriasCLN();
        private Proyecto p = new Proyecto();
        private ProyectosCLN pcln = new ProyectosCLN();
        
        public RegistrarHistoriasWPF()
        {
            InitializeComponent();
            mostrar();
            listarHistorias();
            dgHistorias.CanUserSortColumns = true;
        }
        private void mostrar()
        {
            cbProyecto.DisplayMemberPath = "Nombre";
            cbProyecto.ItemsSource = pcln.listarNombres();
        }

        private void bRegistrar_Click(object sender, RoutedEventArgs e)
        {
            desc = tbDescripcion.Text;
            habilitar = chbHabilitar.IsChecked.Value;
            prioridad = int.Parse(cbPrioridad.Text);
            nombrep = cbProyecto.Text;
            p = pcln.getProyecto(nombrep);
            Historia h = new Historia();
            h.Descripcion = desc;
            h.Prioridad = prioridad;
            h.Habilitado = habilitar;
            h.Proyecto_id = p.id;
            hcln.crearHistoria(h);
            listarHistorias();
            //ordenarHistorias();
        }
        private void listarHistorias()
        {
            dgHistorias.ItemsSource = hcln.listar2();
        }
        //private void ordenarHistorias()
        //{
        //    dgHistorias.CanUserSortColumns = true;
        //    dgHistorias.Columns[2].SortDirection = desc
        //}
            
    }
}
