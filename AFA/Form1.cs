using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFA
{
    public partial class Form1 : Form
    {
        PetManager pm;
        //form initialization
        public Form1(PetManager PM)
        {
            InitializeComponent();
            pm = PM;
        }

        // Button references, would have been much simpler with just one button, and an animal input
        private void CatBtn_Click(object sender, EventArgs e) { ButtonClicked(0); }
        private void DogBtn_Click(object sender, EventArgs e) { ButtonClicked(1); }
        private void BirdBtn_Click(object sender, EventArgs e) { ButtonClicked(2); }
        private void HorseBtn_Click(object sender, EventArgs e) { ButtonClicked(3); }

        // Method for when button is clicked
        private void ButtonClicked(int type)
        {
            DetailsForm window = new DetailsForm(pm, type); // Create and run the detail giving window
            this.Hide();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void CompletedBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompleteGraph window = new CompleteGraph(pm); // Create and run the full graph
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void editPricesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditPricingValues window = new EditPricingValues(); // Create and run the full graph
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
