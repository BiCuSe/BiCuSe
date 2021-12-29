using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using LiveCharts;
using LiveCharts.Wpf;
using WPFModernVerticalMenu.Model;

namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {

        public static Home selfref{get; set;}
        private Model.InternetCheck internet = new InternetCheck();
        public Home()
        {

            InitializeComponent();
            selfref = this;
            Updater();
            this.texttt();
            this.PieChart();

        }



        int refq = 752;
        int refqq = 1400;


        public void texttt()
        {
            int summa = refq + refqq;
            referal.Text = refq.ToString() + "  " + "Rub";
            PC.Text = refqq.ToString()+"  "+"Rub";
            Vseg_Summa.Text = summa.ToString() + "  " + "Rub";

        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        public void PieChart()
        {
            PointLabel = charPoint => string.Format("{0} Руб ", charPoint.Y, charPoint.Participation);
            DataContext = this;

        }

        public void Ok()
        {
            Btn_Start.IsEnabled = true;
            Btn_Stop.IsEnabled = true;
            imgInet.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/Internet_Yes.png"));
            textInet.Content = "Интернет соединение установлено...";
        }

        public void No()
        {

            Btn_Start.IsEnabled = false;
            Btn_Stop.IsEnabled = false;
            imgInet.Source = new BitmapImage(new Uri(@"pack://application:,,,/Resources/Internet_Noy.png"));
            textInet.Content = "Инетрнет соединее отсуцтвует...";
        }

        private void Btn_Start_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn_Stop_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }


        public  void Updater()
        {
            new Thread(() => {
                while (true)
                {
                    Thread.Sleep(10000);
                    bool result = Model.InternetCheck.PingServer(new string[]
                            {
                            @"google.com",
                            @"microsoft.com",
                            @"ibm.com",
                            @"wikipedia.org"
                            });

                    if (result)
                        this.Dispatcher.Invoke((Action)(() => { selfref.Ok(); }));
                    else
                        this.Dispatcher.Invoke((Action)(() => { Home.selfref.No(); }));
                }
            }).Start();
        }

    }
}
