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
        public static DetailsForm window = new DetailsForm();//put pm into the brackets
        private Form1(PetManager pm)//put 'PetManager pm' into the brackets
        {
            InitializeComponent();
        }

        private void CatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
            window.getInfo = 1;
        }

        private void DogBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
            window.getInfo = 2;
        }

        private void BirdBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
            window.getInfo = 3;
        }

        private void HorseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
            window.getInfo = 4;
        }
    }
}
