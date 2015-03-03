using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataVisualization_001
{
    public class NotifyXY : INotifyPropertyChanged
    {
        private double x;
        public double X
        {
            get { return x; }
            set { x = value; OnPropertyChanged(new PropertyChangedEventArgs("X")); }
        }

        private double y;
        public double Y
        {
            get { return y; }
            set { y = value; OnPropertyChanged(new PropertyChangedEventArgs("Y")); }
        }

        public NotifyXY(double inX, double inY)
        {
            X = inX;
            Y = inY;
        }

        //----------------------------------------------------------------
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
