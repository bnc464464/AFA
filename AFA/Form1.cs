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

        public Form1()//put 'PetManager pm' into the brackets
        {
            InitializeComponent();
        }

        public static PetManager pm = new PetManager();

        DetailsForm window = new DetailsForm(pm);//put pm into the brackets

        private void CatBtn_Click(object sender, EventArgs e)
        {
            window.GetAnimalInfo = 1;
            ButtonClicked();
        }

        private void DogBtn_Click(object sender, EventArgs e)
        {
            window.GetAnimalInfo = 2;
            ButtonClicked();
        }

        private void BirdBtn_Click(object sender, EventArgs e)
        {
            window.GetAnimalInfo = 3;
            ButtonClicked();
        }

        private void HorseBtn_Click(object sender, EventArgs e)
        {
            window.GetAnimalInfo = 4;
            ButtonClicked();
        }

        private void ButtonClicked()
        {
            this.Hide();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
