using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        Func<ChartPoint, string> label1 = chartpoint => string.Format("{0} ({1:P)",chartpoint.Y, chartpoint.Participation);
        private void Form1_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in dataSet1.Revenue)
            series.Add(new PieSeries() { Title = obj.Year.ToString(), Values = new ChartValues<int> { obj.Total }, DataLabels = true, LabelPoint = label1 });
            pieChart1.Series = series;
           
                 
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
