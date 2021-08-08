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
        private PetManager pm;
        private int listValue;

        List<DataPoint> yValues = new List<DataPoint>();

        public IndividualGraph(PetManager PM, int ListValue, float totalFood, float foodToPriceRatio)
        {
            // saving vars to public vars available wherever in the doc
            InitializeComponent();
            pm = PM;
            listValue = ListValue;
            pm.totalPets[listValue].WeeklySaving(totalFood, foodToPriceRatio*totalFood);

            // Creating graph
            foreach (float weeklyAverage in pm.totalPets[listValue].TotalWeeklyConsumption)
            {
                DataPoint Dp = new DataPoint();
                Dp.SetValueY(weeklyAverage);
                yValues.Add(Dp);
            }

            // adding points, sorting series names, and making it a line
            chart1.Series.Clear();
            chart1.Series.Add("Food");
            chart1.Series["Food"].MarkerStyle = MarkerStyle.Circle;
            foreach (DataPoint dP in yValues)
                chart1.Series["Food"].Points.Add(dP);
            chart1.Series["Food"].ChartType = SeriesChartType.Line;
            // finished creating graph


            // extra text boxes of info - name, and total cost
            nameTtl.Text = pm.totalPets[listValue].name + "'s Weekly Averages";
            totalCostLbl.Text = "Total Cost: $" + formList(1); //form list and calculate total cost at the same time
        }

        private float formList(int dailyWeeklyDivider)
        {
            // when the list is being changed this is needed
            animalListTxb.Clear();

            //sorting out text height and vars
            float totalCost = 0;
            animalListTxb.AppendText("\r");

            // add each line calculate total cost
            for (int weekNum = 0; weekNum < pm.totalPets[listValue].TotalWeeklyConsumption.Count; weekNum++)
            {
                animalListTxb.AppendText("Week " + Convert.ToString(weekNum + 1) + ": " + (pm.totalPets[listValue].TotalWeeklyConsumption[weekNum]/dailyWeeklyDivider).ToString("n0") + "g    -    $" + (pm.totalPets[listValue].TotalWeeklyPrices[weekNum]/dailyWeeklyDivider).ToString("n0") + "\r\n");
                totalCost += pm.totalPets[listValue].TotalWeeklyPrices[weekNum];
            }

            // sort list size
            Size size = TextRenderer.MeasureText(animalListTxb.Text, animalListTxb.Font);
            animalListTxb.Height = size.Height;
            animalListTxb.Height -= 30;

            return totalCost;
        }

        private void totalsBtn_Click(object sender, EventArgs e)
        {
            // redo list and change button color
            formList(1);
            DailyAvgBtn.BackColor = Color.DarkGray;
            TotalsBtn.BackColor = Color.LightGray;
        }
        private void dailyAvgBtn_Click(object sender, EventArgs e)
        {
            // redo list and change button color
            formList(7);
            DailyAvgBtn.BackColor = Color.LightGray;
            TotalsBtn.BackColor = Color.DarkGray;
        }

        private void IndGphCancelBtn_Click(object sender, EventArgs e)
        {
            // go back to Form 1, homepage
            this.Hide();
            Form1 window = new Form1(pm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
