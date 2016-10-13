using Lesson5.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5
{
    public partial class NextForm : Form
    {

        public AbilityForm previousForm = new AbilityForm();
        public NextForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void NextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void NextForm_Load(object sender, EventArgs e)
        {
            if (Program.character.Race == null)
            {
                RaceListBox.SelectedItem = "Dragon Born";
            }
            else
            {
                RaceListBox.SelectedItem = Program.character.Race;
            }
            
        }

        private void RaceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTextBox.Text = RaceListBox.SelectedItem.ToString();
            Program.character.Race = SelectedTextBox.Text;

            String imageString = Regex.Replace(SelectedTextBox.Text, @"\+", "");

            RacePictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);
        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
    }
}
