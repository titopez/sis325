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
<<<<<<< HEAD
=======
        //private string nombrep;
>>>>>>> 0854c7152f4e36ab6b1bf3b988bff84b4b1c47eb
        private int Horas;
        private HistoriasCLN hcln = new HistoriasCLN();
        private SprintsCLN scln = new SprintsCLN();
        private Proyecto p = new Proyecto();
        private ProyectosCLN pcln = new ProyectosCLN();
<<<<<<< HEAD
        Historia h = new Historia();
=======
        //private SprintCLN scln = new SprintCLN();
        private Historia h = new Historia();
        private int idProy;
        public delegate Point GetDrapDropPosition(IInputElement theElement);
        int prevRowIndex = -1;
>>>>>>> 0854c7152f4e36ab6b1bf3b988bff84b4b1c47eb

        public RegistrarHistoriasWPF(int id)
        {
            InitializeComponent();
            hcln.ordenar();
            idProy = id;
        }

<<<<<<< HEAD
        Form2proyectoM fp = new Form2proyectoM();
       
=======
        //Form2proyectoM fp = new Form2proyectoM();
        private bool IstheMouseOnTargetRow(Visual theTarget, GetDrapDropPosition pos)
        {
            Rect posBounds = VisualTreeHelper.GetDescendantBounds(theTarget);
            Point theMousePos = pos((IInputElement)theTarget);
            return posBounds.Contains(theMousePos);
        }
        private DataGridRow GetDataGridRowItem(int index)
        {
            if (dgHistorias.ItemContainerGenerator.Status != 
                    System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
                return null;
            return dgHistorias.ItemContainerGenerator.ContainerFromIndex(index) as DataGridRow; 
        }
        private int GetDataGridItemCurrentRowIndex(GetDrapDropPosition pos)
        {
            int curindex = -1;
            for (int i = 0; i < dgHistorias.Items.Count; i++)
            {
                DataGridRow itm = GetDataGridRowItem(i);
                if (IstheMouseOnTargetRow(itm, pos))
                {
                    curindex = i;
                    break;
                }
            }
            return curindex;
        }
        
>>>>>>> 0854c7152f4e36ab6b1bf3b988bff84b4b1c47eb
        private void bRegistrar_Click(object sender, RoutedEventArgs e)
        {
            desc = tbDescripcion.Text;
            prioridad = int.Parse(cbPrioridad.Text);
<<<<<<< HEAD
            habilitar = chbHabilitar.IsChecked.Value;
            Horas = int.Parse(tbHoras.Text);
            p = pcln.getProyecto(tbnombrep.Text);
=======
            //nombrep = tbnombrep.Text;
            Horas = int.Parse(tbHoras.Text);
            p = pcln.getProyectoId(idProy);
>>>>>>> 0854c7152f4e36ab6b1bf3b988bff84b4b1c47eb
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
<<<<<<< HEAD
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
=======
            limpiar();
        }
        private void listarHistorias()
        {
            List<Historia> listah = new List<Historia>();
            List<Historia> listah2 = new List<Historia>();
            listah = hcln.listar();
            for(int i=0;i<listah.Count;i++)
            {
                if (listah[i].Proyecto_id == idProy)
                {
                    listah2.Add(listah[i]);
                }
            }
            dgHistorias.ItemsSource = listah2;
>>>>>>> 0854c7152f4e36ab6b1bf3b988bff84b4b1c47eb
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
            tbnombrep.Text = pcln.getProyectoId(idProy).Nombre;
            listarHistorias();
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

        private void limpiar()
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

        private void tbHoras_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))
                e.Handled = true;
        }

        private void bCerrar_Click(object sender, RoutedEventArgs e)
        {
            new Form2proyectoM(idProy).Show();
            this.Close();
        }

        private void bCrearSprint_Click(object sender, RoutedEventArgs e)
        {
            CrearSprintWPF cswpf = new CrearSprintWPF(idProy);
            cswpf.Show();
        }

        private void bCrearTareas_Click(object sender, RoutedEventArgs e)
        {
            CrearTareaWPF cwpf = new CrearTareaWPF(idProy, int.Parse(tbIDH.Text));
            cwpf.Show();
        }

        private void chbHabilitar_Checked(object sender, RoutedEventArgs e)
        {
            if (chbHabilitar.IsChecked == true)
            {
                bCrearTareas.IsEnabled = true;
            }
            else
            {
                bCrearTareas.IsEnabled = false;
            }
        }

        private void chbHabilitar_Click(object sender, RoutedEventArgs e)
        {
            if (chbHabilitar.IsChecked == true)
            {
                Historia h = new Historia();
                h = hcln.getHistoriaId(int.Parse(tbIDH.Text));
                h.Habilitado = true;
                hcln.modificarHistoria(h);
                bCrearTareas.IsEnabled = true;
            }
            else
            {
                bCrearTareas.IsEnabled = false;
            }
        }

        
    }
}
