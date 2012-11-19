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
        //private string nombrep;
        private int Horas;
        private HistoriasCLN hcln = new HistoriasCLN();
        private Proyecto p = new Proyecto();
        private ProyectosCLN pcln = new ProyectosCLN();
        //private SprintCLN scln = new SprintCLN();
        private Historia h = new Historia();
        private int idProy;
        public delegate Point GetDrapDropPosition(IInputElement theElement);
        int prevRowIndex = -1;

        public RegistrarHistoriasWPF(int id)
        {
            InitializeComponent();
            listarHistorias();
            hcln.ordenar();
            idProy = id;
        }

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
        
        private void bRegistrar_Click(object sender, RoutedEventArgs e)
        {
            desc = tbDescripcion.Text;
            habilitar = chbHabilitar.IsChecked.Value;
            prioridad = int.Parse(cbPrioridad.Text);
            //nombrep = tbnombrep.Text;
            Horas = int.Parse(tbHoras.Text);
            p = pcln.getProyectoId(idProy);
            h.Descripcion = desc;
            h.Prioridad = prioridad;
            h.Habilitado = habilitar;
            h.Proyecto_id = p.id;
            h.Cantidad_Horas = Horas;
            hcln.crearHistoria(h);
            MessageBox.Show("La historia fue registrada exitosamente");
            listarHistorias();
            hcln.ordenar();
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
        }

        private void bCancelar_Click(object sender, RoutedEventArgs e)
        {
            int id;
            desc = tbDescripcion.Text;
            h = hcln.getHistoria(desc);
            id = h.id;
            hcln.eliminarHistoria(h);
            MessageBox.Show("se elimino con exito");
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
            h.Proyecto_id = p.id;
            h.id = int.Parse(tbIDH.Text);
            hcln.modificarHistoria(h);
            MessageBox.Show("se actualizo la historia");
            hcln.ordenar();
            
        }
        private void dgHistorias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void limpiar()
        {
            tbDescripcion.Clear();
            cbPrioridad.Text = "";
            tbHoras.Text = "";
            chbHabilitar.IsChecked = false;
            dgHistorias.IsReadOnly = false;
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
            prevRowIndex = GetDataGridItemCurrentRowIndex(e.GetPosition);
            if (prevRowIndex < 0)
            {
                return;
            }
            dgHistorias.SelectedIndex = prevRowIndex;
            Historia SelectedHis = dgHistorias.Items[prevRowIndex] as Historia;
            if (SelectedHis == null)
            {
                return;
            }
            DragDropEffects dragdropeffects = DragDropEffects.Move;
            if (DragDrop.DoDragDrop(dgHistorias, SelectedHis, dragdropeffects) != DragDropEffects.None)
            {
                dgHistorias.SelectedItem = SelectedHis;
            }
        }

        private void dgHistorias_Drop(object sender, DragEventArgs e)
        {
            if (prevRowIndex < 0)
            {
                return;    
            }
            int index = this.GetDataGridItemCurrentRowIndex(e.GetPosition);
            if (index < 0)
            {
                return;
            }
            if (index == prevRowIndex)
            {
                return;
            }
            if (index == dgHistorias.Items.Count - 1)
            {
                MessageBox.Show("la fila no puede usar el drop operation");
                return;
            }
            Collection<Historia> myhis = Resources["Id"] as Collection<Historia>;
            Historia movedHis = myhis[prevRowIndex];
            myhis.RemoveAt(prevRowIndex);
            myhis.Insert(index, movedHis);
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
