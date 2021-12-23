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

namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Логика взаимодействия для Description.xaml
    /// </summary>
    public partial class Description : Page
    {
        public Description()
        {
            InitializeComponent();
        }

        private void Info_Btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://telegra.ph/Opisanie-besplatnogo-bota-i-funkcionala-Vnimatelno-prochitajte-do-konca-chtoby-ponimat-otkuda-dengi-12-16");
        }
    }
}
