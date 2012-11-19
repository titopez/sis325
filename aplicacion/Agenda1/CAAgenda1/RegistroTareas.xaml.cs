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
    /// Lógica de interacción para RegistroTareas.xaml
    /// </summary>
    public partial class RegistroTareas : Window
    {
        private Tarea tarea = new Tarea();
        private Proyecto proyecto = new Proyecto();
        private Historia historia = new Historia();
        private Tareas tcln = new Tareas();
        private ProyectosCLN pcln = new ProyectosCLN();
        private HistoriasCLN hcln = new HistoriasCLN();
        private Rol rol = new Rol();
        private RolesCLN rcln = new RolesCLN();
        public RegistroTareas()
        {
            InitializeComponent();
            mostrarcbIntegrantes();
        }

        private void mostrarcbIntegrantes()
        {
            cbIntegrantes.ItemsSource = rcln.mostrarNombre();
            cbIntegrantes.DisplayMemberPath = "Nombre_Tarea";
        }
        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            tarea.Nombre_Tarea = tbnombreT.Text;
            tarea.Tipo = cbTipo.Text;
            tarea.Estado = cbEstado.Text;
            tarea.Horas = int.Parse(tbHoras.Text);
            tarea.Sprint_id_Sprint = 1;
        }
    }
}
