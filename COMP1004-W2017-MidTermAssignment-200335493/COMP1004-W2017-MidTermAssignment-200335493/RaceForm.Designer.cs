namespace Mid_Term__Assignment
{
    partial class RaceForm
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
            this.race_groupBox = new System.Windows.Forms.GroupBox();
            this.halfling_radioButton = new System.Windows.Forms.RadioButton();
            this.elf_radioButton = new System.Windows.Forms.RadioButton();
            this.dwarf_radioButton = new System.Windows.Forms.RadioButton();
            this.human_radioButton = new System.Windows.Forms.RadioButton();
            this.race_pictureBox = new System.Windows.Forms.PictureBox();
            this.next_button = new System.Windows.Forms.Button();
            this.racialBonus_textBox = new System.Windows.Forms.TextBox();
            this.race_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.race_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // race_groupBox
            // 
            this.race_groupBox.Controls.Add(this.halfling_radioButton);
            this.race_groupBox.Controls.Add(this.elf_radioButton);
            this.race_groupBox.Controls.Add(this.dwarf_radioButton);
            this.race_groupBox.Controls.Add(this.human_radioButton);
            this.race_groupBox.Location = new System.Drawing.Point(30, 22);
            this.race_groupBox.Name = "race_groupBox";
            this.race_groupBox.Size = new System.Drawing.Size(168, 248);
            this.race_groupBox.TabIndex = 0;
            this.race_groupBox.TabStop = false;
            this.race_groupBox.Text = "Race";
            // 
            // halfling_radioButton
            // 
            this.halfling_radioButton.AutoSize = true;
            this.halfling_radioButton.Location = new System.Drawing.Point(22, 176);
            this.halfling_radioButton.Name = "halfling_radioButton";
            this.halfling_radioButton.Size = new System.Drawing.Size(87, 24);
            this.halfling_radioButton.TabIndex = 3;
            this.halfling_radioButton.TabStop = true;
            this.halfling_radioButton.Text = "Halfling";
            this.halfling_radioButton.UseVisualStyleBackColor = true;
            this.halfling_radioButton.CheckedChanged += new System.EventHandler(this.halfling_radioButton_CheckedChanged);
            // 
            // elf_radioButton
            // 
            this.elf_radioButton.AutoSize = true;
            this.elf_radioButton.Location = new System.Drawing.Point(22, 134);
            this.elf_radioButton.Name = "elf_radioButton";
            this.elf_radioButton.Size = new System.Drawing.Size(53, 24);
            this.elf_radioButton.TabIndex = 2;
            this.elf_radioButton.TabStop = true;
            this.elf_radioButton.Text = "Elf";
            this.elf_radioButton.UseVisualStyleBackColor = true;
            this.elf_radioButton.CheckedChanged += new System.EventHandler(this.elf_radioButton_CheckedChanged);
            // 
            // dwarf_radioButton
            // 
            this.dwarf_radioButton.AutoSize = true;
            this.dwarf_radioButton.Location = new System.Drawing.Point(22, 92);
            this.dwarf_radioButton.Name = "dwarf_radioButton";
            this.dwarf_radioButton.Size = new System.Drawing.Size(76, 24);
            this.dwarf_radioButton.TabIndex = 1;
            this.dwarf_radioButton.TabStop = true;
            this.dwarf_radioButton.Text = "Dwarf";
            this.dwarf_radioButton.UseVisualStyleBackColor = true;
            this.dwarf_radioButton.CheckedChanged += new System.EventHandler(this.dwarf_radioButton_CheckedChanged);
            // 
            // human_radioButton
            // 
            this.human_radioButton.AutoSize = true;
            this.human_radioButton.Location = new System.Drawing.Point(22, 50);
            this.human_radioButton.Name = "human_radioButton";
            this.human_radioButton.Size = new System.Drawing.Size(86, 24);
            this.human_radioButton.TabIndex = 0;
            this.human_radioButton.TabStop = true;
            this.human_radioButton.Text = "Human";
            this.human_radioButton.UseVisualStyleBackColor = true;
            this.human_radioButton.CheckedChanged += new System.EventHandler(this.human_radioButton_CheckedChanged);
            // 
            // race_pictureBox
            // 
            this.race_pictureBox.Location = new System.Drawing.Point(260, 22);
            this.race_pictureBox.Name = "race_pictureBox";
            this.race_pictureBox.Size = new System.Drawing.Size(290, 262);
            this.race_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.race_pictureBox.TabIndex = 1;
            this.race_pictureBox.TabStop = false;
            // 
            // next_button
            // 
            this.next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.Location = new System.Drawing.Point(389, 369);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(161, 53);
            this.next_button.TabIndex = 3;
            this.next_button.TabStop = false;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // racialBonus_textBox
            // 
            this.racialBonus_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.racialBonus_textBox.Location = new System.Drawing.Point(30, 307);
            this.racialBonus_textBox.Name = "racialBonus_textBox";
            this.racialBonus_textBox.Size = new System.Drawing.Size(520, 28);
            this.racialBonus_textBox.TabIndex = 4;
            this.racialBonus_textBox.TabStop = false;
            // 
            // RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 447);
            this.ControlBox = false;
            this.Controls.Add(this.racialBonus_textBox);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.race_pictureBox);
            this.Controls.Add(this.race_groupBox);
            this.MaximumSize = new System.Drawing.Size(586, 503);
            this.MinimumSize = new System.Drawing.Size(586, 503);
            this.Name = "RaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RaceForm_FormClosed);
            this.race_groupBox.ResumeLayout(false);
            this.race_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.race_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox race_groupBox;
        private System.Windows.Forms.RadioButton halfling_radioButton;
        private System.Windows.Forms.RadioButton elf_radioButton;
        private System.Windows.Forms.RadioButton dwarf_radioButton;
        private System.Windows.Forms.RadioButton human_radioButton;
        private System.Windows.Forms.PictureBox race_pictureBox;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.TextBox racialBonus_textBox;
    }
}