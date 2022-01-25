using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Harjoitus_23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        kiuas kiuas1 = new kiuas();
        public MainWindow()
        {
            InitializeComponent();
            kiuas1.VaihdaLämpötila(10);
            kiuas1.VaihdaKosteus(10);
            kiuas1.OnkoPäällä = false;
        }

        private void btn_lämpötilaDown_Click(object sender, RoutedEventArgs e)
        {
            int uusilämpötila = kiuas1.Lämpötila + 5;
            kiuas1.VaihdaLämpötila(uusilämpötila);
            tb_lämpötila.Text = kiuas1.Lämpötila.ToString();
        }

        private void btn_KosteusUp_Click(object sender, RoutedEventArgs e)
        {
            int uusilämpötila = kiuas1.Lämpötila - 5;
            kiuas1.VaihdaLämpötila(uusilämpötila);
            tb_lämpötila.Text = kiuas1.Lämpötila.ToString();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9] + ");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(input_Kosteus.Text !="")
            {

            kiuas1.VaihdaKosteus(int.Parse(input_Kosteus.Text));
            tb_kosteus.Text = kiuas1.Kosteus.ToString();
            }
        }
    }
}
