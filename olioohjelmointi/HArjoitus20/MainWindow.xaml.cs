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

namespace HArjoitus20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<opiskelija> opiskelijat = new List<opiskelija>();

        public MainWindow()
        {

            InitializeComponent();

            dg_Opiskelijat.ItemsSource = opiskelijat;

        }

        private void btn_lisääopiskelija_Click(object sender, RoutedEventArgs e)
        {
            string etunimi = input_etunimi.Text;
            string sukunimi = input_sukunimi.Text;
            string puhelinnumero = input_puhelinnumero.Text;
            string sähköposti = input_sähköposti.Text;
            string opiskelijaID = input_opiskelijaID.Text;

            opiskelijat.Add(new opiskelija(etunimi, sukunimi, puhelinnumero, sähköposti, opiskelijaID));
            dg_Opiskelijat.ItemsSource = opiskelijat;

            input_etunimi.Text = "";
            input_sukunimi.Text = "";
            input_puhelinnumero.Text = "";
            input_sähköposti.Text = "";
            input_opiskelijaID.Text = "";
        }

        private void btn_poistaOpiskelijat_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
