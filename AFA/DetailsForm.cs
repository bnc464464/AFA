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
        public PetManager pm
        { get; set; }
        public DetailsForm(PetManager PM)//put 'PetManager pm' into the brackets
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
        public int getAnimalInfo
        {
            get; set;
        }

        private void DetailsContinueBtn_Click(object sender, EventArgs e)
        {

            //if name is the same as any of the other names make a text box otherwise doing the other one for now.


            string message = "Would you like to add a new pet?";
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.OK)
            {
                List<int> Consumption = new List<int>() { Convert.ToInt32(Day1Nud), Convert.ToInt32(Day2Nud), Convert.ToInt32(Day3Nud), Convert.ToInt32(Day4Nud), Convert.ToInt32(Day5Nud), Convert.ToInt32(Day6Nud), Convert.ToInt32(Day7Nud) };

                //THE ERROR IS HEREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE

                pm.totalPets.Add(new Pet(Convert.ToString(NameTxb), Consumption, getAnimalInfo));
                message = "Succesfully Added";
                caption = "Pet Added Succesfully";
                buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(message, caption, buttons);

                this.Hide();
                Form1 window = new Form1();//put pm into the brackets
                window.FormClosed += (s, args) => this.Close();
                window.Show();
            }
            if (result == DialogResult.Cancel)
            {
                //do nothing
            }
        }
    }
}
