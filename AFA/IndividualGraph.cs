using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AFA
{
    public partial class IndividualGraph : Form
    {
        public PetManager pm;

        List<DataPoint> yValues = new List<DataPoint>();

        public IndividualGraph(PetManager PM, int listValue)
        {
            InitializeComponent();
            pm = PM;
            pm.totalPets[listValue].WeeklyAvg();

            foreach (float weeklyAverage in pm.totalPets[listValue].TotalConsumption)
            {
                DataPoint Dp = new DataPoint();
                Dp.SetValueY(weeklyAverage);
                yValues.Add(Dp);
            }

            chart1.Series.Clear();
            chart1.Series.Add("Food");
            foreach (DataPoint dP in yValues)
            {
                chart1.Series["Food"].Points.Add(dP);
            }

            chart1.Series["Food"].ChartType = SeriesChartType.Line;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
