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
        PetManager pm = new PetManager();

        List<double> xValues = new List<double>();
        List<double> yValues = new List<double>();

        public IndividualGraph()
        {
            InitializeComponent();
            foreach (Pet pet in pm.totalPets)
            {
                yValues.Add(pet.WeeklyAvg());
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
        }
    }
}
