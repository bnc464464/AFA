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
    public partial class DetailsForm : Form
    {
        private PetManager pm;
        private int listValue;
        private int getAnimalInfo;
        public DetailsForm(PetManager PM, int type)
        {
            // save necessary vars to full document ones
            InitializeComponent();
            pm = PM;
            getAnimalInfo = type;

            // set up the display for price
            PriceEditorLbl.Text = "$"+PetManager.petFood[getAnimalInfo, 0]+" per " + PetManager.petFood[getAnimalInfo, 1] +"g";
        }

        private void DetailCancelBtn_Click(object sender, EventArgs e)
        {
            // go back to Form 1, homepage 
            this.Hide();
            Form1 window = new Form1(pm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void DetailsContinueBtn_Click(object sender, EventArgs e)
        {
            if (NameTxb.Text.Equals(""))
            {
                MessageBox.Show("Please enter a name", "Name Empty!", MessageBoxButtons.OK);
            }
            else
            {
                // calculate total food
                List<int> consumption = new List<int>() { Convert.ToInt32(Day1Nud.Value), Convert.ToInt32(Day2Nud.Value), Convert.ToInt32(Day3Nud.Value), Convert.ToInt32(Day4Nud.Value), Convert.ToInt32(Day5Nud.Value), Convert.ToInt32(Day6Nud.Value), Convert.ToInt32(Day7Nud.Value) };
                float totalFood = 0;
                foreach (int amount in consumption)
                    totalFood += amount;

                // calculate food to cost
                float foodToPriceRatio = (float)PetManager.petFood[getAnimalInfo, 0] / PetManager.petFood[getAnimalInfo, 1];

                // if name is the same as any of the other names make a text box otherwise doing the other one for now.
                bool nameFound = false;
                listValue = 0;
                bool petExists = false;
                while (nameFound == false)
                {
                    foreach (Pet pet in pm.totalPets)
                    {
                        if (pet.name.ToLower() == NameTxb.Text.ToLower() && pet.animal == getAnimalInfo)
                        {
                            // if the data has already been stored for the week
                            if (pet.weekIntercept + pet.TotalWeeklyConsumption.Count == pm.weeksSinceStartup + 1)
                            {
                                MessageBox.Show(pet.name + "'s week of food has already been uploaded", "Week Already Added", MessageBoxButtons.OK);
                            }
                            else // otherwise
                            {
                                // do some checks and then add food if checks fulfilled
                                DialogResult result2 = MessageBox.Show("Would you like to add this food under " + NameTxb.Text + "?", "Pet Found", MessageBoxButtons.OKCancel);

                                if (result2 == DialogResult.OK)
                                {
                                    result2 = MessageBox.Show("Details Added\nTotal food consumed: " + totalFood + "g\nTotal weekly cost: $" + (foodToPriceRatio * totalFood).ToString("n2"), "Finished Adding", MessageBoxButtons.OK);
                                    CreateNewWindow(totalFood, foodToPriceRatio);
                                }
                                else
                                    MessageBox.Show("Please enter a different name", "Pet Already Exists", MessageBoxButtons.OK);

                            }
                            // necessary for exiting loop, and for the next dialog sequences
                            petExists = true;
                            nameFound = true;
                        }
                        else
                            listValue++;
                    }
                    nameFound = true;
                }

                if (!petExists)
                {
                    DialogResult result = MessageBox.Show("Would you like to add a new pet?", "", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        // new pet code
                        pm.totalPets.Add(new Pet(NameTxb.Text, getAnimalInfo, pm.weeksSinceStartup));

                        MessageBox.Show("Succesfully Added: " + Convert.ToString(pm.totalPets[pm.totalPets.Count - 1].name) + "\nTotal food consumed: " + totalFood + "g\nTotal weekly cost: $" + (foodToPriceRatio * totalFood).ToString("n0"), "Pet Added Succesfully", MessageBoxButtons.OK);

                        // create a graph window
                        CreateNewWindow(totalFood, foodToPriceRatio);
                    }
                }
            }
        }

        public void CreateNewWindow(float totalFood, float foodToPriceRatio)
        {
            // go onto next graph page
            this.Hide();
            IndividualGraph window = new IndividualGraph(pm, listValue, totalFood, foodToPriceRatio);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void editPricesBtn_Click(object sender, EventArgs e)
        {
            // go to edit prices button
            this.Hide();
            EditPricingValues window = new EditPricingValues(1, getAnimalInfo); // create and run the full graph
            window.FormClosed += (s, args) => this.Close();
            window.Show();
            
        }
    }
}
