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
        public RegistrarNuevoRolWPF()
        {
            InitializeComponent();
            mostrar();
        }

        private void bRegistrarRol_Click(object sender, RoutedEventArgs e)
        {
            nombre = tbNombre.Text;
            rol = tbRol.Text;
            rolSec = tbRolSec.Text;
            Proyecto p = pcln.getProyecto(cbNombreProy.Text);
            Rol r = new Rol();
            r.NombreCompleto = nombre;
            r.Responsabilidad = rol;
            r.ResponsabilidadSecundaria = rolSec;
            r.Proyecto_id = p.id;
            rolcln.crearRol(r);
        }
        private void mostrar()
        {
            cbNombreProy.DisplayMemberPath = "Nombre";
            cbNombreProy.ItemsSource = pcln.listarNombres();
        }
    }
}

