using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            BackBtn_Click(sender, e);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Hide();
        }

        private void NextForm_Load(object sender, EventArgs e)
        {
            RaceListBox.SelectedItem = "Dragon Born";
        }

        private void RaceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTextBox.Text = RaceListBox.SelectedItem.ToString();
        }
    }
}
