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
using System.Windows.Shapes;

namespace GTS
{
    /// <summary>
    /// Interaction logic for dashboard.xaml
    /// </summary>
    public partial class dashboard : Window
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void Cls_btn_dashboard_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            
            demandeAcces dem = new demandeAcces();
            dem.Show();



        }
       

       
    }
}

