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
        public PetManager pm;
        public int listValue;
        public int getAnimalInfo;
        public DetailsForm(PetManager PM, int type)
        {
            InitializeComponent();
            pm = PM;
            getAnimalInfo = type;
        }

        private void DetailCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 window = new Form1(pm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void DetailsContinueBtn_Click(object sender, EventArgs e)
        {
            //calculate total food
            List<int> consumption = new List<int>() { Convert.ToInt32(Day1Nud.Value), Convert.ToInt32(Day2Nud.Value), Convert.ToInt32(Day3Nud.Value), Convert.ToInt32(Day4Nud.Value), Convert.ToInt32(Day5Nud.Value), Convert.ToInt32(Day6Nud.Value), Convert.ToInt32(Day7Nud.Value) };
            float totalFood = 0;
            foreach (int amount in consumption)
                totalFood += amount;

            //calculate food to cost
            float foodToPriceRatio = (float)PetManager.petFood[getAnimalInfo, 0] / PetManager.petFood[getAnimalInfo, 1];

            //if name is the same as any of the other names make a text box otherwise doing the other one for now.
            bool nameFound = false;
            listValue = 0;
            bool petExists = false;
            while (nameFound == false)
            {
                foreach (Pet pet in pm.totalPets)
                {
                    if (pet.name.ToLower() == NameTxb.Text.ToLower() && pet.animal == getAnimalInfo)
                    {
                        DialogResult result2 = AddMiniWindow("Would you like to add this food under " + NameTxb.Text + "?", "Pet Found", MessageBoxButtons.OKCancel);

                        if (result2 == DialogResult.OK)
                        {
                            result2 = AddMiniWindow("Details Added\nTotal food consumed: "+totalFood + "g\nTotal weekly cost: $" + (foodToPriceRatio * totalFood).ToString("n2"), "Finished Adding", MessageBoxButtons.OK);
                            CreateNewWindow(totalFood, foodToPriceRatio);
                        }
                        else
                            AddMiniWindow("Please enter a different name", "Pet Already Exists", MessageBoxButtons.OK);

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
                DialogResult result = AddMiniWindow("Would you like to add a new pet?", "", MessageBoxButtons.OKCancel);
            
                if (result == DialogResult.OK)
                {
                    //new pet code
                    pm.totalPets.Add(new Pet(NameTxb.Text, getAnimalInfo));

                    AddMiniWindow("Succesfully Added: " + Convert.ToString(pm.totalPets[pm.totalPets.Count - 1].name) + "\nTotal food consumed: " + totalFood + "g\nTotal weekly cost: $" + (foodToPriceRatio * totalFood).ToString("n0"), "Pet Added Succesfully", MessageBoxButtons.OK);

                    //Create a graph window
                    CreateNewWindow(totalFood, foodToPriceRatio);
                }
            }
        }

        public DialogResult AddMiniWindow(string message, string caption, MessageBoxButtons buttons)
        {
            DialogResult result = MessageBox.Show(message, caption, buttons);
            return result;
        }

        public void CreateNewWindow(float totalFood, float foodToPriceRatio)
        {
            this.Hide();
            IndividualGraph window = new IndividualGraph(pm, listValue, totalFood, foodToPriceRatio);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
