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
        private int idHis;
        public CrearTareaWPF(int id, int idH)
        {
            InitializeComponent();
            idProy = id;
            idHis = idH;
        }

        private void bCrear_Click(object sender, RoutedEventArgs e)
        {
            if ((tbNombre.Text.Equals("")) || (tbIdTarea.Text.Equals("")) || (tbHoras.Text.Equals("")))
                MessageBox.Show("Todos los campos son obligatorios");
            else
            {
                Tarea t = new Tarea();
                t.id_tarea = int.Parse(tbIdTarea.Text);
                t.Nombre_Tarea = tbNombre.Text;
                t.Estado = cbEstado.SelectedItem.ToString();
                t.Rol_id = rcln.getRolNombre(cbResponsable.SelectedItem.ToString()).id;
                t.Tipo = cbTipo.SelectedItem.ToString();
                t.Horas = int.Parse(tbHoras.Text);
                t.Historia_id = int.Parse(tbHistoria.Text.ToString());
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
            }
            limpiar();
            //cargarDatos();

        }

        public void limpiar()
        {
            tbHoras.Text = "";
            tbNombre.Text = "";
            tbIdTarea.Text = "";
        }

        private void wCrearTarea_Loaded(object sender, RoutedEventArgs e)
        {
            cargarDatos();
 
        }

        private void cargarDatos()
        {
            tbSprint.Text = scln.getSprintActivo(idProy, "Activo").id.ToString();
            tbHistoria.Text = idHis.ToString();
            string valorItem;
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
        }
    }
}
