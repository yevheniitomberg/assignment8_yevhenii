using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment8_yevhenii
{
    public partial class Form1 : Form
    {

        public List<string> boysNames = new List<string>();
        public List<string> girlsNames = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.selectBox.DataSource = new List<string>() {"Boys", "Girls"};
            fillListsWithNames();
        }

        private void fillListsWithNames()
        {
            boysNames = System.IO.File.ReadAllLines(@"../../src/BoysNames.txt").ToList();
            girlsNames = System.IO.File.ReadAllLines(@"../../src/GirlsNames.txt").ToList();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (this.inputName.Text.Length < 2)
            {
                this.labelStatus.Text = "Wrong name";
            }
            else if (this.selectBox.Text == "Boys")
            {
                this.labelStatus.Text = boysNames.Contains(this.inputName.Text) ? this.inputName.Text + " is a popular name" : this.inputName.Text + " is NOT a popular name";
            }
            else if (this.selectBox.Text == "Girls")
            {
                this.labelStatus.Text = girlsNames.Contains(this.inputName.Text) ? this.inputName.Text + " is a popular name" : this.inputName.Text + " is NOT a popular name";

            }
            else
            {
                this.labelStatus.Text = "Wrong select type";
            }
        }
    }
}
