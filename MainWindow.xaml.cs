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

namespace ColorChange_Special_char
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
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = textBox.Text;

            if (string.IsNullOrEmpty(text))
            {
                this.Background = new SolidColorBrush(Colors.White);
            }
            else if (text.All(char.IsLetter))
            {
                this.Background = new SolidColorBrush(Colors.LightBlue);
            }
            else if (text.All(char.IsDigit))
            {
                this.Background = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                this.Background = new SolidColorBrush(Colors.LightGray);
            }
        }
    }
}
