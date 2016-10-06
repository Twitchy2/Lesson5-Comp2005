using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5
{
    public partial class AbilityForm : Form
    {

        private Random _random;
        public AbilityForm()
        {
            InitializeComponent();
            this._Initalize();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _Initalize()
        {
            this._random = new Random(); //starts the random
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            RollAbilities();
        }
        /// <summary>
        /// Will get the ability points
        /// </summary>
        public void RollAbilities()
        {
            Program.character.Strength = Roll4D6();
            StrengthTextBo.Text = Program.character.Strength.ToString();
            Program.character.Dexxterity = Roll4D6();
            DexterityTextBox.Text = Program.character.Dexxterity.ToString();
            Program.character.Intelligence = Roll4D6();
            IntelligenceTextBox.Text = Program.character.Intelligence.ToString();
            Program.character.Constitution = Roll4D6();
            ConstitutionTextBox.Text = Program.character.Constitution.ToString();
            Program.character.Wisdom = Roll4D6();
            WisdomTextBox.Text = Program.character.Wisdom.ToString();
            Program.character.Charisma = Roll4D6();
            CharismaTextBox.Text = Program.character.Charisma.ToString();

        }
        /// <summary>
        /// roll a random number retunrs the highest 3 dice
        /// </summary>
        private int Roll4D6()
        {
            List<int> dice = new List<int>();
            //roll 4d6
            for (int count = 0; count < 4; count++) {
                dice.Add(this._random.Next(1, 7));
                
            }
            dice.Sort();

            dice.RemoveAt(0);

            return dice.Sum();
        }

        private void AbilityForm_Load(object sender, EventArgs e)
        {
            RollAbilities();
        }
    }
}
