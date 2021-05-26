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
            // getting the series values
            List<float> catValues = new List<float>();
            catValues = pm.AvgPetWeeklys(1);

            List<float> dogValues = new List<float>();
            dogValues = pm.AvgPetWeeklys(2);

            List<float> birdValues = new List<float>();
            birdValues = pm.AvgPetWeeklys(3);

            List<float> horseValues = new List<float>();
            horseValues = pm.AvgPetWeeklys(4);

            //creating points on graph
            chart1.Series.Clear();

            chart1.Series.Add("Cat");
            foreach (float point in catValues)
            {
                DataPoint Dp = new DataPoint();
                Dp.SetValueY(point);
                chart1.Series["Cat"].Points.Add(point);
            }
            chart1.Series["Cat"].ChartType = SeriesChartType.Line;
            
            chart1.Series.Add("Dog");
            foreach (float point in dogValues)
            {
                DataPoint Dp = new DataPoint();
                Dp.SetValueY(point);
                chart1.Series["Dog"].Points.Add(point);
            }
            chart1.Series["Dog"].ChartType = SeriesChartType.Line;
            
            chart1.Series.Add("Bird");
            foreach (float point in birdValues)
            {
                DataPoint Dp = new DataPoint();
                Dp.SetValueY(point);
                chart1.Series["Bird"].Points.Add(point);
            }
            chart1.Series["Bird"].ChartType = SeriesChartType.Line;
            
            chart1.Series.Add("Horse");
            foreach (float point in horseValues)
            {
                DataPoint Dp = new DataPoint();
                Dp.SetValueY(point);
                chart1.Series["Horse"].Points.Add(point);
            }
            chart1.Series["Horse"].ChartType = SeriesChartType.Line;


            // The Lists

            int weekNum = 1;
            Font font = new Font(new System.Drawing.FontFamily("Palatino Linotype"), 11);
            foreach (float weeklyAverage in catValues)
            {
                Label point = new Label();
                point.Text = "Week " + weekNum + ": " + weeklyAverage + "g";

                point.Font = font;
                point.Location = new Point(10, cnpControllerCat.Controls.Count * 20);

                cnpControllerCat.Controls.Add(point);
                weekNum++;
            }
            foreach (float weeklyAverage in dogValues)
            {
                Label point = new Label();
                point.Text = "Week " + weekNum + ": " + weeklyAverage + "g";

                point.Font = font;
                point.Location = new Point(10, cnpControllerDog.Controls.Count * 20);

                cnpControllerDog.Controls.Add(point);
                weekNum++;
            }
            foreach (float weeklyAverage in birdValues)
            {
                Label point = new Label();
                point.Text = "Week " + weekNum + ": " + weeklyAverage + "g";

                point.Font = font;
                point.Location = new Point(10, cnpControllerBird.Controls.Count * 20);

                cnpControllerBird.Controls.Add(point);
                weekNum++;
            }
            foreach (float weeklyAverage in horseValues)
            {
                Label point = new Label();
                point.Text = "Week " + weekNum + ": " + weeklyAverage + "g";

                point.Font = font;
                point.Location = new Point(10, cnpControllerHorse.Controls.Count * 20);

                cnpControllerHorse.Controls.Add(point);
                weekNum++;
            }
        }


        private void ComGphCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 window = new Form1();//put pm into the brackets
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
