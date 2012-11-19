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
    /// Lógica de interacción para CrearRolWPF.xaml
    /// </summary>
    public partial class CrearRolWPF : Window
    {
        //Form2proyectoM fp = new Form2proyectoM();
        private Proyecto proy = new Proyecto();
        private RolesCLN rolcln = new RolesCLN();
        private ProyectosCLN pcln = new ProyectosCLN();
        private int idProy;
        public CrearRolWPF(int id)
        {
            InitializeComponent();
            idProy = id;
        }

        private void bCrearRol_Click(object sender, RoutedEventArgs e)
        {
            if ((tbNombre.Text.Equals("")) || (tbRol.Text.Equals("")) || (tbRolSecundario.Text.Equals("")))
                MessageBox.Show("Todos los campos son obligatorios");
            else
            {
                Rol r = new Rol();
                r.NombreCompleto = tbNombre.Text;
                r.Responsabilidad = tbRol.Text;
                r.ResponsabilidadSecundaria = tbRolSecundario.Text;
                proy = pcln.getProyecto(tbProyecto.Text);
                r.Proyecto_id = proy.id;
                rolcln.crearRol(r);
                MessageBox.Show("Rol asignado a proyecto correctamente");
            }

            limpiar();
        }

        private void limpiar()
        {
            tbNombre.Text = "";
            tbRol.Text = "";
            tbRolSecundario.Text = "";
        }

        private void bCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void wCrearRol_Loaded(object sender, RoutedEventArgs e)
        {
            tbProyecto.Text = pcln.getProyectoId(idProy).Nombre;
        }
    }
}
