﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CAAgenda1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bCrearProy_Click(object sender, RoutedEventArgs e)
        {
            NuevoProyectoWPF npwpf = new NuevoProyectoWPF();
            npwpf.Show();
        }

        private void bAsignarRoles_Click(object sender, RoutedEventArgs e)
        {
            RegistrarNuevoRolWPF rnrwpf = new RegistrarNuevoRolWPF();
            rnrwpf.Show();

        }

        private void bCrearHist_Click(object sender, RoutedEventArgs e)
        {
            RegistrarHistoriasWPF rhwpf = new RegistrarHistoriasWPF();
            rhwpf.Show();
        }

        private void bSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
