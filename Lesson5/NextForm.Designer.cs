namespace Lesson5
{
    partial class NextForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RaceListBox = new System.Windows.Forms.ListBox();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.SelectedLabel = new System.Windows.Forms.Label();
            this.SelectedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RaceListBox
            // 
            this.RaceListBox.FormattingEnabled = true;
            this.RaceListBox.ItemHeight = 21;
            this.RaceListBox.Items.AddRange(new object[] {
            "Cuck",
            "Dragon Born",
            "Dwarf",
            "Elf",
            "Half-elf",
            "Half-Ogre",
            "Half-Orc",
            "Halfling",
            "Human",
            "Tiefling"});
            this.RaceListBox.Location = new System.Drawing.Point(17, 51);
            this.RaceListBox.Name = "RaceListBox";
            this.RaceListBox.Size = new System.Drawing.Size(188, 214);
            this.RaceListBox.Sorted = true;
            this.RaceListBox.TabIndex = 2;
            this.RaceListBox.SelectedIndexChanged += new System.EventHandler(this.RaceListBox_SelectedIndexChanged);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(13, 13);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(192, 21);
            this.RaceLabel.TabIndex = 3;
            this.RaceLabel.Text = "Pick Your Race";
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.AutoSize = true;
            this.SelectedLabel.Location = new System.Drawing.Point(219, 98);
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(179, 21);
            this.SelectedLabel.TabIndex = 4;
            this.SelectedLabel.Text = "Race Selected";
            // 
            // SelectedTextBox
            // 
            this.SelectedTextBox.Location = new System.Drawing.Point(223, 122);
            this.SelectedTextBox.Name = "SelectedTextBox";
            this.SelectedTextBox.Size = new System.Drawing.Size(175, 28);
            this.SelectedTextBox.TabIndex = 5;
            // 
            // NextForm
            // 
            this.ClientSize = new System.Drawing.Size(429, 377);
            this.Controls.Add(this.SelectedTextBox);
            this.Controls.Add(this.SelectedLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.RaceListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NextForm";
            this.Text = "Race Form";
            this.Load += new System.EventHandler(this.NextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox RaceListBox;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label SelectedLabel;
        private System.Windows.Forms.TextBox SelectedTextBox;
    }
}