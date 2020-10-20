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

namespace Cryptioner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String data, result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void base64Dec_Click(object sender, RoutedEventArgs e)
        {
            data = input.Text;
            result = Functions.Base64Decode(data);
            output.Text = result;
        }

        private void base64Enc_Click(object sender, RoutedEventArgs e)
        {
            data = input.Text;
            result = Functions.Base64Encode(data);
            output.Text = result;
        }
    }
}
