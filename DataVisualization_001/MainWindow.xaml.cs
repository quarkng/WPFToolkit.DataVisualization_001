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
        }

        private void btnBar1_Click(object sender, RoutedEventArgs e)
        {
            barChart.ItemsSource = Data;
        }
    }
}
