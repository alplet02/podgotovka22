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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void sum2_button_Click(object sender, RoutedEventArgs e)
        {
            Class1 x = new Class1();
            double res = x.Vich(Convert.ToDouble(this.aa_box.Text), Convert.ToDouble(this.bb_box.Text));
            this.result.Text = res.ToString();
        }
    }
}
