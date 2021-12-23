using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для withdrawal_money.xaml
    /// </summary>
    public partial class withdrawal_money : Page
    {
        public withdrawal_money()
        {
            InitializeComponent();
        }


        #region Всплывающие подсказки
        private void ButtonNext_Order_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txt_Summa.Text.Equals(""))
            {
                Popup.PlacementTarget = txt_Summa;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Сумма вывода не указанна!!!";
            }
            else if (txtNumber.Text.Equals(""))
            {
                Popup.PlacementTarget = txtNumber;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Номер киви кошелька не указан";
            }
        }

        private void ButtonNext_Order_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }



        private void ButtonNext_Btc_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtSummaBtc.Text.Equals(""))
            {
                Popup.PlacementTarget = txtSummaBtc;
                Popup.Placement = PlacementMode.Left;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Сумма вывода не указанна!!!";
            }
            else if (txtBtcAdress.Text.Equals(""))
            {
                Popup.PlacementTarget = txtBtcAdress;
                Popup.Placement = PlacementMode.Left;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Номер киви кошелька не указан";
            }
        }

        private void ButtonNext_Btc_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        #endregion

        //Клик по кнопке Продолжить Биткоин
        private void ButtonNext_Btc_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        //Клик по кнопке продолжить киви
        private void ButtonNext_Order_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
