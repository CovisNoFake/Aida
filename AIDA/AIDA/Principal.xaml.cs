﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace AIDA
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Principal : Page
    {
        public Principal()
        {
            this.InitializeComponent();
        }
        private void CreaTarea(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CrearTare));
        }
        private void Inicio(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Principal));
        }
        private void Usuarios(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AgregaUsuario));
        }
        private void Tarea(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tareas));
        }
        private void Buscar(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Buscar));
        }
        private void Perfil(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Perfil));
        }
         private void Ajustes(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ajustes));
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            if (!this.nav.IsPaneOpen)
            {
                this.nav.IsPaneOpen = true;
            }
            else
            {
                this.nav.IsPaneOpen = false;
            }
        }


    }
}
