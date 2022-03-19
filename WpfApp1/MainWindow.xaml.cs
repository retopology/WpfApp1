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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(xtxt.Text);
            double y = Convert.ToDouble(ytxt.Text);
            int yInt = Convert.ToInt32(y);

            double end = (3 + Math.Round(Math.E, yInt - 1)) / (1 + x * x * Math.Abs(y - Math.Tan(x)));
            MessageBox.Show(end.ToString());
        }
    }
}
