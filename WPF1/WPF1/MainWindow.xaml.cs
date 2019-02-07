﻿//Hayley Hunter 
//Collaborated with Connor Keyes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EntryForm ef = new EntryForm();
            ef.Name = tbx1.Text;
            ef.Address = tbx2.Text;
            ef.ZipCode = Convert.ToInt32(tbx3.Text);

            listbox.Items.Add(ef);

        }

        private void Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
