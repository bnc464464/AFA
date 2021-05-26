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

        public IndividualGraph(PetManager PM, int listValue, List<int> consumption)
        {
            // Creating graph
            InitializeComponent();
            pm = PM;
            pm.totalPets[listValue].WeeklyAvg(consumption);

            foreach (float weeklyAverage in pm.totalPets[listValue].TotalConsumption)
            {
                DataPoint Dp = new DataPoint();
                Dp.SetValueY(weeklyAverage);
                yValues.Add(Dp);
            }

            chart1.Series.Clear();
            chart1.Series.Add("Food");
            foreach (DataPoint dP in yValues)
                chart1.Series["Food"].Points.Add(dP);
            chart1.Series["Food"].ChartType = SeriesChartType.Line;

            // finished creating graph


            int weekNum = 1;
            Font font = new Font(new System.Drawing.FontFamily("Palatino Linotype"), 11);
            foreach (float weeklyAverage in pm.totalPets[listValue].TotalConsumption)
            {
                Label point = new Label();
                point.Text = "Week " + weekNum + ": " + weeklyAverage + "g";

                point.Font = font;
                point.Location = new Point(10, cnp_controller.Controls.Count * 20);

                cnp_controller.Controls.Add(point);
                weekNum++;
            }

            nameTtl.Text = pm.totalPets[listValue].name;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void IndGphCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 window = new Form1();//put pm into the brackets
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

    }
}
