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
    public partial class EditPricingValues : Form
    {
        // set up the variables for containing pet info, and for keeping the food prices
        public static PetManager pm = new PetManager();
        public string[,] costAndSize;
        int homeOrDetails;
        int type;
        public EditPricingValues(int homeOrDetail, int getAnimalInfo)
        {
            type = getAnimalInfo;
            homeOrDetails = homeOrDetail;
            InitializeComponent();
        }

        private void DetailsContinueBtn_Click(object sender, EventArgs e)
        {
            costAndSize = new string[8, 2] // forms a list of the values, but now with seperate tags for whether that value is a 0 or not
            {
                { Convert.ToString(catCost.Value), "no" }, { Convert.ToString(catFoodAmount.Value), "no" }, { Convert.ToString(dogCost.Value), "no" }, { Convert.ToString(dogFoodAmount.Value), "no" },
                { Convert.ToString(birdCost.Value), "no" }, { Convert.ToString(birdFoodAmount.Value), "no" }, { Convert.ToString(horseCost.Value), "no" }, { Convert.ToString(horseFoodAmount.Value), "no" }
            };
            // checks if this is the first time the values have been accessed - yes if they have, no if they haven't
            string yesOrNo = System.IO.File.ReadLines("FoodDetails.txt").Skip(4).Take(1).First(); 

            int n;
            // create the error dialog box if the text file has been unchanged
            if (!yesOrNo.Equals("yes")) 
            {
                // this is for checking for zeroes, or unchanged values
                foreach (string foodValues in costAndSize) 
                {
                    if (foodValues.Equals("0"))
                    {
                        DialogResult errorBox = MessageBox.Show("Please fill in the information", "Variable Unknown", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            else // asigns the correct tag for whether the value is 0 or not if the text
            {
                // this is for checking for zeroes, or unchanged values
                for (n = 0; n < 8;) 
                {
                    if (costAndSize[n, 0] == null || costAndSize[n, 0].Equals("0"))
                        costAndSize[n, 1] = "yes";
                    else
                        costAndSize[n, 1] = "no";
                    n++;
                }
            }

            // gets the original list to fill in any 0 values
            string[] inbetweenLines = System.IO.File.ReadAllLines("FoodDetails.txt");
            string[] lines = new string[8];
            for (n = 0; n < 4;)
            {
                string[] inbetweenerLines = inbetweenLines[n].Split(',');
                lines[2 * n] = inbetweenerLines[0];
                lines[2 * n + 1] = inbetweenerLines[1];
                n++;
            }

            // if all info given and it hasn't been done before, save it
            string text = "";
            for (n = 0; n < 8;)
            {
                // will always output true on the first alteration, and from then only true if the value isn't 0
                if (!costAndSize[n, 1].Equals("yes")) 
                    text += costAndSize[n, 0];
                else
                    text += lines[n];

                // when on the specific locations needed for dividers and new lines
                if (n == 0 || n == 2 || n == 4 || n == 6) 
                    text += ","; // dividers
                else
                    text += "\n"; // new lines
                n++;
            }
            DialogResult checker = MessageBox.Show("New Prices: \n"+text, "Change Prices?", MessageBoxButtons.OKCancel);

            if (checker == DialogResult.OK)
            {
                text += "yes"; // always assign a yes value after the first change
                System.IO.File.WriteAllText("FoodDetails.txt", text); // actually put the text string on the file
                pm.LoadFoodSettings();

                // enter the previous page
                if (homeOrDetails == 0)
                {
                    this.Hide();
                    Form1 window = new Form1(pm);
                    window.FormClosed += (s, args) => this.Close();
                    window.Show();
                }
                else
                {
                    this.Hide();
                    DetailsForm window = new DetailsForm(pm, type);
                    window.FormClosed += (s, args) => this.Close();
                    window.Show();
                }
            }
        }
    }
}
