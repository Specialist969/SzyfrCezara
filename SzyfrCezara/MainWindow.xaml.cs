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

namespace SzyfrCezara
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        ///  Algorytm Cezara - szyfruje kod poprzez zamiane liter o wskazaną wartość
        /// </summary>
        public MainWindow()
        {
            //char[] alfabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        }

        private void Szyfr_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = Console.ReadLine();
        }
    }
}

//https://4programmers.net/Forum/C_i_.NET/346475-szyfr_cezara

//https://e.sggw.pl/mod/page/view.php?id=40622

//https://mateuszrus.pl/szyfr-cezara/