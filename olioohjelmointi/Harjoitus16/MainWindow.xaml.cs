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

namespace Harjoitus16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float KmToMilesvalue = 0.62137f;
        float MilesToKmvalue = 1.60934f;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_MilesToKm_Click(object sender, RoutedEventArgs e)
        {
            float value = float.Parse(txt_Input.Text);
            float muunnettuArvo = value * MilesToKmvalue;
            TB_lopputulos.Text = value + "mailia on " + muunnettuArvo + " km";
        }

        private void btn_KmToMiles_Click(object sender, RoutedEventArgs e)
        {
            float value = float.Parse(txt_Input.Text);
            float muunnettuArvo = value * KmToMilesvalue;
            TB_lopputulos.Text=value + "kilometriä on " + value + "km";

        }
    }
}
