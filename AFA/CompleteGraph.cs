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
    public partial class CompleteGraph : Form
    {
        PetManager pm;
        public CompleteGraph(PetManager PM)
        {
            InitializeComponent();
            pm = PM;

            //creating points on graph and list
            DataPointsAdding(new List<TextBox>() { catListTxb, dogListTxb, birdListTxb, horseListTxb }, new List<Label>() { TCCatLbl, TCDogLbl, TCBirdLbl, TCHorseLbl });

        }

        private void DataPointsAdding(List<TextBox> animalBoxes, List<Label> animalTotals)
        {
            float[] totalCosts = new float[4];
            float[] totalWeeklyFood = new float[pm.weeksSinceStartup+1];
            float[] totalWeeklyCosts = new float[pm.weeksSinceStartup+1];

            // for each pet type
            List<Chart> GRAPHS = new List<Chart>() { catChart, dogChart, birdChart, horseChart };
            List<string> GRAPHNAMES = new List<String>() { "Cat", "Dog", "Bird", "Horse" };
            for (int i = 0; i < 4; i++)
            {
                //setup and add chart axis labels
                pm.AvgPetWeeklys(i);
                GRAPHS[i].Series.Clear();
                GRAPHS[i].ChartAreas["ChartArea1"].AxisX.Title = "Time in Weeks";
                GRAPHS[i].ChartAreas["ChartArea1"].AxisY.Title = "Total Food Consumed (g)";
                
                // fix list height 1
                animalBoxes[i].AppendText("\r");

                foreach (Pet pet in pm.totalPets)
                {
                    if (pet.animal == i)
                    {
                        GRAPHS[i].Series.Add(pet.name);
                        GRAPHS[i].Series[pet.name].ChartType = SeriesChartType.Line;
                        GRAPHS[i].Series[pet.name].MarkerStyle = MarkerStyle.Circle;

                        while (GRAPHS[i].Series[pet.name].Points.Count < pet.weekIntercept)
                        {
                            GRAPHS[i].Series[pet.name].Points.Add(0);
                        }
                        foreach (int food in pet.TotalWeeklyConsumption)
                        {
                            GRAPHS[i].Series[pet.name].Points.Add(food);
                        }
                    }
                }

                for (int weekNum = 0; weekNum < pm.WeeklyFoodTotals.Count; weekNum++)
                {
                    // totals stuff
                    totalWeeklyCosts[weekNum] += pm.totalWeekCost[weekNum];
                    totalWeeklyFood[weekNum] += pm.WeeklyFoodTotals[weekNum];
                    totalCosts[i] += pm.totalWeekCost[weekNum];
                    // add text
                    animalBoxes[i].AppendText("Week " + Convert.ToString(weekNum + 1) + ": " + pm.WeeklyFoodTotals[weekNum].ToString("n0") + "g    -    $" + pm.totalWeekCost[weekNum] + "g\r\n");
                }

                // fix list height 2
                Size size = TextRenderer.MeasureText(animalBoxes[i].Text, animalBoxes[i].Font);
                animalBoxes[i].Height = size.Height;
                animalBoxes[i].Height -= 30;
                animalTotals[i].Text = "Total Cost: " + totalCosts[i];

            }

            // total graph stuff
            TTotalCostLbl.Text = "Total Cost: $" + Convert.ToString(totalCosts[0] + totalCosts[1] + totalCosts[2] + totalCosts[3]);
            completeChart.ChartAreas["ChartArea1"].AxisX.Title = "Time in Weeks";
            completeChart.ChartAreas["ChartArea1"].AxisY.Title = "Total Food Consumed (g)";

            fullAvgTxb.AppendText("\r");
            for (int weekNum = 0; weekNum < pm.weeksSinceStartup+1; weekNum++)
            {
                // graph stuff
                completeChart.Series["Food"].Points.Add(totalWeeklyFood[weekNum]);

                fullAvgTxb.AppendText("Week " + Convert.ToString(weekNum + 1) + ": " + totalWeeklyCosts[weekNum].ToString("n0") + "g    -    $" + totalWeeklyFood[weekNum] + "g\r\n");
            }
            Size size2 = TextRenderer.MeasureText(fullAvgTxb.Text, fullAvgTxb.Font);
            fullAvgTxb.Height = size2.Height;
            fullAvgTxb.Height -= 30;

            completeChart.Series["Food"].ChartType = SeriesChartType.Line;
            completeChart.Series["Food"].MarkerStyle = MarkerStyle.Circle;
        }

        private void ComGphCancelBtn_Click(object sender, EventArgs e)
        {
            // go back to Form 1, homepage
            this.Hide();
            Form1 window = new Form1(pm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // go back to Form 1, homepage
            this.Hide();
            Form1 window = new Form1(pm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void Exit2_Click(object sender, EventArgs e)
        {
            // go back to Form 1, homepage
            this.Hide();
            Form1 window = new Form1(pm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void Exit3_Click(object sender, EventArgs e)
        {
            // go back to Form 1, homepage
            this.Hide();
            Form1 window = new Form1(pm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void Exit4_Click(object sender, EventArgs e)
        {
            // go back to Form 1, homepage
            this.Hide();
            Form1 window = new Form1(pm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
