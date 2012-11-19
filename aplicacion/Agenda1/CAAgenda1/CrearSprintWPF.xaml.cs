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
    /// Lógica de interacción para CrearSprintWPF.xaml
    /// </summary>
    public partial class CrearSprintWPF : Window
    {
        private SprintCLN sprintcln = new SprintCLN();
        private Sprint sprint = new Sprint();
        private int idProy;
        public CrearSprintWPF(int id)
        {
            InitializeComponent();
            idProy = id;
        }

        private void bCrear_Click(object sender, RoutedEventArgs e)
        {
            if ((tbObjetivo.Text.Equals("")) || (tbDuracion.Text.Equals("")))
                MessageBox.Show("Todos los campos son obligatorios");
            else
            {
                sprint.Duracion = int.Parse(tbDuracion.Text);
                sprint.Inicio = DateTime.Parse(dpFechaIni.SelectedDate.ToString());
                sprint.Estado = "Activo";
                sprint.Horas_Pendientes = 0;
                sprint.Tareas_Pendientes = 0;
                sprint.Objetivo = tbObjetivo.ToString();
                sprint.Proyecto_id = idProy;
                sprintcln.crearSprint(sprint);
                MessageBox.Show("Sprint creado correctamente");
            }
            limpiar();
        }
        private void limpiar()
        {
            tbDuracion.Text = "";
        }

        private void bCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
