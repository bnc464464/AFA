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
        // form initialization
        public Form1(PetManager PM)
        {
            InitializeComponent();
            pm = PM;
        }

        // button references, would have been much simpler with just one button, and an animal input
        private void CatBtn_Click(object sender, EventArgs e) { ButtonClicked(0); }
        private void DogBtn_Click(object sender, EventArgs e) { ButtonClicked(1); }
        private void BirdBtn_Click(object sender, EventArgs e) { ButtonClicked(2); }
        private void HorseBtn_Click(object sender, EventArgs e) { ButtonClicked(3); }

        // method for when button is clicked
        private void ButtonClicked(int type)
        {
            // create and run the detail giving window
            DetailsForm window = new DetailsForm(pm, type); 
            this.Hide();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void CompletedBtn_Click(object sender, EventArgs e)
        {
            float[] totalCosts = new float[4];
            bool dontDoIt = false;
            // check for animals left unfed
            foreach (Pet pet in pm.totalPets)
            {
                while (pet.weekIntercept + pet.TotalWeeklyConsumption.Count <= pm.weeksSinceStartup)
                {
                    DialogResult feedChecker = MessageBox.Show(pet.name+" hasn't been fed this week!\nPress <OK> to continue", "Pet Left Unfed", MessageBoxButtons.OKCancel);
                    if (feedChecker == DialogResult.Cancel)
                        dontDoIt = true;
                    pet.WeeklySaving(0, 0);
                }

                totalCosts[pet.animal] += pet.TotalWeeklyPrices[pet.TotalWeeklyPrices.Count - 1];
            }
            if (!dontDoIt)
            {
                // show the totals message
                MessageBox.Show("Week " + (pm.weeksSinceStartup+1) + " Totals:\nTotal Cat Cost: "+totalCosts[0]+ "\nTotal Dog Cost: " + totalCosts[1] + "\nTotal Bird Cost: " + totalCosts[2] 
                    + "\nTotal Horse Cost: " + totalCosts[1]+"\nTotal Cost: " + (totalCosts[0] + totalCosts[1] + totalCosts[2] + totalCosts[3]), "Week Completed!", MessageBoxButtons.OK);

                // create and run the full graph
                this.Hide();
                CompleteGraph window = new CompleteGraph(pm);
                window.FormClosed += (s, args) => this.Close();
                window.Show();
                pm.weeksSinceStartup++;
            }
        }

        private void editPricesBtn_Click(object sender, EventArgs e)
        {
            // go to edit prices button
            this.Hide();
            EditPricingValues window = new EditPricingValues(0, 0); // create and run the full graph
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
