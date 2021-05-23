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
        public DetailsForm(PetManager PM)
        {
            InitializeComponent();
            pm = PM;
        }

        private void DetailCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 window = new Form1();//put pm into the brackets
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
        public int GetAnimalInfo
        {
            get; set;
        }

        private void DetailsContinueBtn_Click(object sender, EventArgs e)
        {
            string message;
            string caption;
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

            //if name is the same as any of the other names make a text box otherwise doing the other one for now.
            bool nameFound = false;
            listValue = 0;
            bool petExists = false;
            while (nameFound == false)
            {
                foreach (Pet pet in pm.totalPets)
                {
                    if (pet.name.ToLower() == NameTxb.Text.ToLower())
                    {
                        DialogResult result2 = AddMiniWindow("Would you like to add this food under " + NameTxb.Text + "?", "Pet Found", MessageBoxButtons.OKCancel);

                        if (result2 == DialogResult.OK)
                        {
                            result2 = AddMiniWindow("Details Added", "Finished Adding", MessageBoxButtons.OK);

                            CreateNewWindow();
                        }

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
                message = "Would you like to add a new pet?";
                caption = "";

                DialogResult result = MessageBox.Show(message, caption, buttons);
            

                if (result == DialogResult.OK)
                {
                    if (petExists)
                    {
                        AddMiniWindow("Please enter a different name", "Pet Already Exists", MessageBoxButtons.OK);
                    }
                    else
                    {
                        pm.totalPets.Add(new Pet(NameTxb.Text, GetAnimalInfo));

                        listValue = pm.totalPets.Count - 1;
                        AddMiniWindow("Succesfully Added: " + Convert.ToString(pm.totalPets[listValue].name), "Pet Added Succesfully", MessageBoxButtons.OK);

                        //Form1 window = new Form1();//put pm into the brackets
                        CreateNewWindow();

                    }
                }
                if (result == DialogResult.Cancel)
                {
                    //do nothing
                }
            }
        }

        public DialogResult AddMiniWindow(string message, string caption, MessageBoxButtons buttons)
        {
            DialogResult result = MessageBox.Show(message, caption, buttons);
            return result;
        }

        public void CreateNewWindow()
        {
            List<int> consumption = new List<int>() { Convert.ToInt32(Day1Nud.Value), Convert.ToInt32(Day2Nud.Value), Convert.ToInt32(Day3Nud.Value), Convert.ToInt32(Day4Nud.Value), Convert.ToInt32(Day5Nud.Value), Convert.ToInt32(Day6Nud.Value), Convert.ToInt32(Day7Nud.Value) };
            this.Hide();
            IndividualGraph window = new IndividualGraph(pm, listValue, consumption);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
