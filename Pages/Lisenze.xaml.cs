using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для Lisenze.xaml
    /// </summary>
    public partial class Lisenze : Page
    {
        public Lisenze()
        {
            InitializeComponent();
            BTC();
        }

        string btc = "1BvBMSEYstWetqTFn5Au4m4GFg7xJaNVN2";

        public void BTC()
        {

            txt_Btc.Text = btc;

        }


        private void btn_Order_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btn_Order_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtlog.Text.Equals("") || txtSpon.Text.Equals(""))
            {
                Popup.PlacementTarget = btn_Order;
                Popup.Placement = PlacementMode.Bottom;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Поле логин или поле Логин спорсора не заполненно";
            }
        }

        private void btn_Order_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
    }
}
