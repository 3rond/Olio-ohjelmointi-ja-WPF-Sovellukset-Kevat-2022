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

namespace Harjoitus_17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        float lämpötila = 20;
        bool keittiövalot = false;
        bool olohuoneenvalot = false;
        bool ovilukossa = true;
        public MainWindow()
        {
            InitializeComponent();

            tb_läpötila.Text = "talon sisälämpötila on" + lämpötila;
            tb_keittiötila.Text = keittiövalot.ToString();
            tb_Olohuonetila.Text = olohuoneenvalot.ToString();
            btn_ovi.Content = ovilukossa.ToString();
        }

        private void btn_olohuone_Click(object sender, RoutedEventArgs e)
        {
            olohuoneenvalot = !olohuoneenvalot;
            tb_Olohuonetila.Text = olohuoneenvalot.ToString();
        }

        private void btn_keittiö_Click(object sender, RoutedEventArgs e)
        {
            keittiövalot = !keittiövalot;
            tb_keittiötila.Text = keittiövalot.ToString();
        }

        private void btn_ovi_Click(object sender, RoutedEventArgs e)
        {
            ovilukossa = !ovilukossa;
            btn_ovi.Content = ovilukossa.ToString();
        }

        private void txt_termostaatti_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Jos käyttäjä antaa jotain muuta kuin numeroita, toteutetaan tämä if lause
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_termostaatti.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_termostaatti.Text = "";
            }
            else
            {
                if(txt_termostaatti.Text == "")
                {
                    return;
                }
                lämpötila = int.Parse(txt_termostaatti.Text);
                tb_läpötila.Text = "Talon sisälämpötila on " + lämpötila;
            }
        }
    }
}
