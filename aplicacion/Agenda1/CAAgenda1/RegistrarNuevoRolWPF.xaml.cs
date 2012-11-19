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
using CLNAgenda1;
using CADAgenda1;

namespace CAAgenda1
{
    /// <summary>
    /// Lógica de interacción para RegistrarNuevoRolWPF.xaml
    /// </summary>
    public partial class RegistrarNuevoRolWPF : Window
    {
        private String nombre;
        private String rol;
        private String rolSec;
        private ProyectosCLN pcln = new ProyectosCLN();
        private RolesCLN rolcln = new RolesCLN();
        private Rol r = new Rol();
        public RegistrarNuevoRolWPF()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void bRegistrarRol_Click(object sender, RoutedEventArgs e)
        {
            nombre = tbNombre.Text;
            rol = tbRol.Text;
            rolSec = tbRolSec.Text;
            Proyecto p = pcln.getProyecto(tbProyecto.Text);
            r.NombreCompleto = nombre;
            r.Responsabilidad = rol;
            r.ResponsabilidadSecundaria = rolSec;
            r.Proyecto_id = p.id;
            rolcln.crearRol(r);
            MessageBox.Show("Se creo al usuario " + nombre + " satisfactoriamente!!");
            dgRoles.ItemsSource = rolcln.mostrar(r.Proyecto_id);
            tbNombre.Clear();
            tbRol.Clear();
            tbRolSec.Clear();
            
        }
   
        private void bCancelar_Click(object sender, RoutedEventArgs e)
        {
            FormProyecto principal = new FormProyecto();
            principal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            r.NombreCompleto = tbNombre.Text;
            r.Responsabilidad = tbRol.Text;
            r.ResponsabilidadSecundaria = tbRolSec.Text;
            Proyecto p = pcln.getProyecto(tbProyecto.Text);
            r.Proyecto_id = p.id;
            r.id = int.Parse(tbIdr.Text);
            rolcln.Modificar(r);
            MessageBox.Show("Se modico al usuario");
            dgRoles.ItemsSource = rolcln.mostrar(r.Proyecto_id);
            tbNombre.Clear();
            tbRol.Clear();
            tbRolSec.Clear();
            
        }
    }
}

