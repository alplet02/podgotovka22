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
using MatchLibrary;

namespace Экзамен.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void first_button_Click(object sender, RoutedEventArgs e)
        {
           
           
            double res =Class1.Sum(Convert.ToDouble(this.a_box.Text),Convert.ToDouble(this.b_box.Text));
            this.resault.Text = res.ToString();
        }
    }
}
