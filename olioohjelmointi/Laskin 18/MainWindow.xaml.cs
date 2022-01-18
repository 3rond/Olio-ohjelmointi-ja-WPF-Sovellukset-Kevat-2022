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

namespace Laskin_18
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
        private void btn_summa_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_numero1.Text) + float.Parse(txt_numero2.Text);
            Tb_lopputulos.Text = tulos.ToString();
        }

        private void btn_erotus_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_numero1.Text) - float.Parse(txt_numero2.Text);
            Tb_lopputulos.Text = tulos.ToString();
        }

        private void btn_kertolasku_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_numero1.Text) * float.Parse(txt_numero2.Text);
            Tb_lopputulos.Text = tulos.ToString();
        }

        private void btn_jakolasku_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_numero1.Text) / float.Parse(txt_numero2.Text);
            Tb_lopputulos.Text = tulos.ToString();
        }
    }
}
