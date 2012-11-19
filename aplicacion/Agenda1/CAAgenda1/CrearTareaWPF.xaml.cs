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
    /// Lógica de interacción para CrearTareaWPF.xaml
    /// </summary>
    public partial class CrearTareaWPF : Window
    {
        private TareaCLN tcln = new TareaCLN();
        private int idProy;
        private RolesCLN rcln = new RolesCLN();
        private HistoriasCLN hcln = new HistoriasCLN();
        private SprintCLN scln = new SprintCLN();
        private int idSprint;
        public CrearTareaWPF(int id, int ids)
        {
            InitializeComponent();
            idProy = id;
            idSprint = ids;
        }

        private void bCrear_Click(object sender, RoutedEventArgs e)
        {
            Tarea t = new Tarea();
            t.Nombre_Tarea = tbNombre.Text;
            t.Estado = cbEstado.SelectedItem.ToString();
            t.Rol_id = rcln.getRolNombre(cbResponsable.SelectedItem.ToString()).id;
            t.Tipo = cbTipo.SelectedItem.ToString();
            t.Horas = int.Parse(tbHoras.Text);
            t.Historia_id = int.Parse(cbHistorias.SelectedItem.ToString());
            //adicionamos la cantidad de tareas al sprint y ademas
            //incrementamos la cantidad de horas para el sprint de todas las tareas
            t.Sprint_id = int.Parse(tbSprint.Text.ToString());
            Sprint sprint = new Sprint();
            sprint = scln.buscarSprint(t.Sprint_id);
            sprint.Tareas_Pendientes++;
            sprint.Horas_Pendientes = sprint.Horas_Pendientes + t.Horas;          
            scln.modificarSprint(sprint);
            //creamos las tareas
            tcln.crearTarea(t);
            MessageBox.Show("Tarea asignada exitosamente");
            limpiar();

        }

        public void limpiar()
        {
            tbHoras.Text = "";
            tbNombre.Text = "";
            tbSprint.Text = "";
        }

        private void wCrearTarea_Loaded(object sender, RoutedEventArgs e)
        {
            List<Historia> listh = new List<Historia>();
            listh = hcln.listar();
            string valorItem;
            for (int i = 0; i < listh.Count; i++)
            {
                if (idProy == listh[i].Proyecto_id)
                {
                    valorItem = listh[i].id.ToString();
                    cbHistorias.Items.Add(valorItem);
                }
            }
            List<Rol> listr = new List<Rol>();
            listr = rcln.listarRoles();
           
            for (int i = 0; i <= listr.Count; i++)
            {
                if (idProy == listr[i].Proyecto_id)
                {
                    valorItem = listr[i].NombreCompleto;
                    cbResponsable.Items.Add(valorItem);
                }
            }    
            tbSprint.Text = idSprint.ToString();
        }
    }
}
