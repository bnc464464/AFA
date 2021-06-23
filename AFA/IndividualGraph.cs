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

        public IndividualGraph(PetManager PM, int listValue, float totalFood, float foodToPriceRatio)
        {
            // Creating graph
            InitializeComponent();
            pm = PM;

            pm.totalPets[listValue].WeeklyAvg(totalFood, foodToPriceRatio*totalFood);

            foreach (float weeklyAverage in pm.totalPets[listValue].AverageDailyConsumption)
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


            // form the list
            int weekNum = 1;
            float totalCost = 0;
            Font font = new Font(new System.Drawing.FontFamily("Palatino Linotype"), 11); // font

            for (int i = 0; i < pm.totalPets[listValue].AverageDailyConsumption.Count; i++)
            {
                Label point = new Label(); // create label and apply text and settings
                point.Text = "Week " + weekNum + ": " + pm.totalPets[listValue].AverageDailyConsumption[i].ToString("n0") + "g    -    " +pm.totalPets[listValue].TotalWeeklyPrices[i];
                totalCost += pm.totalPets[listValue].TotalWeeklyPrices[i];
                point.Font = font;
                point.Location = new Point(10, cnp_controller.Controls.Count * 20);

                cnp_controller.Controls.Add(point);
                weekNum++;
            }

            nameTtl.Text = pm.totalPets[listValue].name + "'s Weekly Averages";
            totalCostLbl.Text = "Total Cost: $" + totalCost;
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
