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

            //creating points on graph
            GraphPointsAdding(pm.AvgPetWeeklys(0));

            // The Lists
            ListPointsAdding(pm.AvgPetWeeklys(0), catListTxb);
            ListPointsAdding(pm.AvgPetWeeklys(1), dogListTxb);
            ListPointsAdding(pm.AvgPetWeeklys(2), birdListTxb);
            ListPointsAdding(pm.AvgPetWeeklys(3), horseListTxb);

            animalCtr.SelectedIndexChanged += new EventHandler(AnimalCtr_SelectedIndexChanged);
        }

        private void GraphPointsAdding (List<float> animalValues)
        {
            chart1.Series.Clear();
            List<string> GRAPHNAMES = new List<String>() { "Cat", "Dog", "Bird", "Horse" };
            for (int i = 0; i < 4; i++)
            {
                chart1.Series.Add(GRAPHNAMES[i]);
                foreach (float point in animalValues)
                {
                    DataPoint Dp = new DataPoint();
                    Dp.SetValueY(point);
                    chart1.Series[GRAPHNAMES[i]].Points.Add(point);
                }
                chart1.Series[GRAPHNAMES[i]].ChartType = SeriesChartType.Line;
            }
        }

        private void ListPointsAdding (List<float> animalValues, TextBox animalBox)
        {
            for (int weekNum = 0; weekNum < animalValues.Count; weekNum++)
            {
                animalBox.AppendText("Week " + Convert.ToString(weekNum + 1) + ": " + animalValues[weekNum].ToString("n0") + "g\r\n");
                if (weekNum > animalBox.Height / 20)
                    animalBox.Height += 20;

                if (animalValues.Count > 1)
                    animalBox.Height += 25 / animalValues.Count;
            }
        }

        private void ComGphCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 window = new Form1(pm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void AnimalCtr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Titles
            if (animalCtr.SelectedTab == animalCtr.TabPages["catValues"])
                typeTtl.Text = "Cats";
            else if (animalCtr.SelectedTab == animalCtr.TabPages["dogValues"])
                typeTtl.Text = "Dogs";
            else if (animalCtr.SelectedTab == animalCtr.TabPages["birdValues"])
                typeTtl.Text = "Birds";
            else
                typeTtl.Text = "Horses";
        }
    }
}
