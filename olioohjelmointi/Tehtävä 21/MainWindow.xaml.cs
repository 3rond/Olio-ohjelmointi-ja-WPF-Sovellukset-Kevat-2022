﻿using System;
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

namespace Tehtävä_21
{
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Poista = false;
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(txt_textBox1.Text);
            
        }

       

        private void btn_poista_Click_1(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Remove(txt_textBox1.Text);
        }
    }
}
