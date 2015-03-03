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
using System.Windows.Controls.DataVisualization.Charting;
using System.Collections.ObjectModel;


// Quick Notes:
// http://www.codeproject.com/Articles/196502/WPF-Toolkit-Charting-Controls-Line-Bar-Area-Pie-Co
// https://wpf.codeplex.com/releases/view/40535
// https://github.com/dotnetprojects/wpftoolkit
//
// Newer? https://www.nuget.org/packages/DotNetProjectsWPFToolkit/

namespace DataVisualization_001
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static SampleDataVM sdvm = new SampleDataVM();
        private Dictionary<string, int> Data = sdvm.Data;


        public MainWindow()
        {
            InitializeComponent();

            colChart.ItemsSource = Data;

            lineSer1.ItemsSource = lnSr1;
            lineSer2.ItemsSource = lnSr2;
        }

        private void btnBar1_Click(object sender, RoutedEventArgs e)
        {
            barChart.ItemsSource = Data;
        }


        //===============================================================
        private ObservableCollection<NotifyXY> lnSr1 = new ObservableCollection<NotifyXY>();
        private ObservableCollection<NotifyXY> lnSr2 = new ObservableCollection<NotifyXY>();

        private double x1 = -10;
        private double x2 = -10;
        private Random rnd1 = new Random();

        private void btnLine1_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                x1 += ((float)rnd1.Next(1, 10)) / 10.0;
                double y1 = ((float)rnd1.Next(1, 100)) / 10.0;
                lnSr1.Add(new NotifyXY(x1, y1));

                x2 += ((float)rnd1.Next(1, 10)) / 10.0;
                double y2 = ((float)rnd1.Next(1, 100)) / 10.0;
                lnSr2.Add(new NotifyXY(x2, y2));
            }
        }
    }
}
