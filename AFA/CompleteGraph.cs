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
            List<DataPoint> catValues = new List<DataPoint>();
            catValues = pm.AvgPetWeeklys(1);

            List<DataPoint> dogValues = new List<DataPoint>();
            dogValues = pm.AvgPetWeeklys(2);

            List<DataPoint> birdValues = new List<DataPoint>();
            birdValues = pm.AvgPetWeeklys(3);

            List<DataPoint> horseValues = new List<DataPoint>();
            horseValues = pm.AvgPetWeeklys(4);

            //creating points on graph
            chart1.Series.Clear();

            chart1.Series.Add("Cat");
            foreach (DataPoint dP in catValues)
                chart1.Series["Cat"].Points.Add(dP);
            chart1.Series["Cat"].ChartType = SeriesChartType.Line;
            
            chart1.Series.Add("Dog");
            foreach (DataPoint dP in dogValues)
                chart1.Series["Dog"].Points.Add(dP);
            chart1.Series["Dog"].ChartType = SeriesChartType.Line;
            
            chart1.Series.Add("Bird");
            foreach (DataPoint dP in birdValues)
                chart1.Series["Bird"].Points.Add(dP);
            chart1.Series["Bird"].ChartType = SeriesChartType.Line;
            
            chart1.Series.Add("Horse");
            foreach (DataPoint dP in horseValues)
                chart1.Series["Horse"].Points.Add(dP);
            chart1.Series["Horse"].ChartType = SeriesChartType.Line;
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
