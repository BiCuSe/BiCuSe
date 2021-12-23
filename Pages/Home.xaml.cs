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


        public Home()
        {
            InitializeComponent();
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

        private void Btn_Start_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn_Stop_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        /* private void PieChart_DataClick(object sender, LiveCharts.ChartPoint chartPoint)
         {
             var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;
             foreach (PieSeries pieSeries in chart.Series)
                 pieSeries.PushOut = 0;
             var seleccionarSeries = (PieSeries)chartPoint.SeriesView;
             seleccionarSeries.PushOut = 5;
         }*/






    }
}
