namespace Mid_Term__Assignment
{
    partial class FinalForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Abilities_groupBox = new System.Windows.Forms.GroupBox();
            this.CHA_textBox = new System.Windows.Forms.TextBox();
            this.PER_textBox = new System.Windows.Forms.TextBox();
            this.INT_textBox = new System.Windows.Forms.TextBox();
            this.END_textBox = new System.Windows.Forms.TextBox();
            this.DEX_textBox = new System.Windows.Forms.TextBox();
            this.STR_textBox = new System.Windows.Forms.TextBox();
            this.CHA_label = new System.Windows.Forms.Label();
            this.PER_label = new System.Windows.Forms.Label();
            this.INT_label = new System.Windows.Forms.Label();
            this.END_label = new System.Windows.Forms.Label();
            this.DEX_label = new System.Windows.Forms.Label();
            this.STR_label = new System.Windows.Forms.Label();
            this.race_pictureBox = new System.Windows.Forms.PictureBox();
            this.characterInformation_groupBox = new System.Windows.Forms.GroupBox();
            this.weight_textBox = new System.Windows.Forms.TextBox();
            this.height_textBox = new System.Windows.Forms.TextBox();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.weight_label = new System.Windows.Forms.Label();
            this.height_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.health_label = new System.Windows.Forms.Label();
            this.race_label = new System.Windows.Forms.Label();
            this.job_label = new System.Windows.Forms.Label();
            this.health_textBox = new System.Windows.Forms.TextBox();
            this.race_textBox = new System.Windows.Forms.TextBox();
            this.job_textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.Abilities_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.race_pictureBox)).BeginInit();
            this.characterInformation_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Abilities_groupBox
            // 
            this.Abilities_groupBox.Controls.Add(this.CHA_textBox);
            this.Abilities_groupBox.Controls.Add(this.PER_textBox);
            this.Abilities_groupBox.Controls.Add(this.INT_textBox);
            this.Abilities_groupBox.Controls.Add(this.END_textBox);
            this.Abilities_groupBox.Controls.Add(this.DEX_textBox);
            this.Abilities_groupBox.Controls.Add(this.STR_textBox);
            this.Abilities_groupBox.Controls.Add(this.CHA_label);
            this.Abilities_groupBox.Controls.Add(this.PER_label);
            this.Abilities_groupBox.Controls.Add(this.INT_label);
            this.Abilities_groupBox.Controls.Add(this.END_label);
            this.Abilities_groupBox.Controls.Add(this.DEX_label);
            this.Abilities_groupBox.Controls.Add(this.STR_label);
            this.Abilities_groupBox.Location = new System.Drawing.Point(350, 50);
            this.Abilities_groupBox.Name = "Abilities_groupBox";
            this.Abilities_groupBox.Size = new System.Drawing.Size(227, 350);
            this.Abilities_groupBox.TabIndex = 1;
            this.Abilities_groupBox.TabStop = false;
            this.Abilities_groupBox.Text = "Abilities";
            // 
            // CHA_textBox
            // 
            this.CHA_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHA_textBox.Location = new System.Drawing.Point(105, 298);
            this.CHA_textBox.Name = "CHA_textBox";
            this.CHA_textBox.ReadOnly = true;
            this.CHA_textBox.Size = new System.Drawing.Size(100, 30);
            this.CHA_textBox.TabIndex = 11;
            this.CHA_textBox.TabStop = false;
            // 
            // PER_textBox
            // 
            this.PER_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PER_textBox.Location = new System.Drawing.Point(105, 247);
            this.PER_textBox.Name = "PER_textBox";
            this.PER_textBox.ReadOnly = true;
            this.PER_textBox.Size = new System.Drawing.Size(100, 30);
            this.PER_textBox.TabIndex = 10;
            this.PER_textBox.TabStop = false;
            // 
            // INT_textBox
            // 
            this.INT_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INT_textBox.Location = new System.Drawing.Point(105, 196);
            this.INT_textBox.Name = "INT_textBox";
            this.INT_textBox.ReadOnly = true;
            this.INT_textBox.Size = new System.Drawing.Size(100, 30);
            this.INT_textBox.TabIndex = 9;
            this.INT_textBox.TabStop = false;
            // 
            // END_textBox
            // 
            this.END_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.END_textBox.Location = new System.Drawing.Point(105, 145);
            this.END_textBox.Name = "END_textBox";
            this.END_textBox.ReadOnly = true;
            this.END_textBox.Size = new System.Drawing.Size(100, 30);
            this.END_textBox.TabIndex = 8;
            this.END_textBox.TabStop = false;
            // 
            // DEX_textBox
            // 
            this.DEX_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEX_textBox.Location = new System.Drawing.Point(105, 94);
            this.DEX_textBox.Name = "DEX_textBox";
            this.DEX_textBox.ReadOnly = true;
            this.DEX_textBox.Size = new System.Drawing.Size(100, 30);
            this.DEX_textBox.TabIndex = 7;
            this.DEX_textBox.TabStop = false;
            // 
            // STR_textBox
            // 
            this.STR_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STR_textBox.Location = new System.Drawing.Point(105, 43);
            this.STR_textBox.Name = "STR_textBox";
            this.STR_textBox.ReadOnly = true;
            this.STR_textBox.Size = new System.Drawing.Size(100, 30);
            this.STR_textBox.TabIndex = 6;
            this.STR_textBox.TabStop = false;
            // 
            // CHA_label
            // 
            this.CHA_label.AutoSize = true;
            this.CHA_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHA_label.Location = new System.Drawing.Point(20, 300);
            this.CHA_label.Name = "CHA_label";
            this.CHA_label.Size = new System.Drawing.Size(61, 25);
            this.CHA_label.TabIndex = 5;
            this.CHA_label.Text = "CHA:";
            // 
            // PER_label
            // 
            this.PER_label.AutoSize = true;
            this.PER_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PER_label.Location = new System.Drawing.Point(20, 248);
            this.PER_label.Name = "PER_label";
            this.PER_label.Size = new System.Drawing.Size(57, 25);
            this.PER_label.TabIndex = 4;
            this.PER_label.Text = "PER:";
            // 
            // INT_label
            // 
            this.INT_label.AutoSize = true;
            this.INT_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INT_label.Location = new System.Drawing.Point(21, 196);
            this.INT_label.Name = "INT_label";
            this.INT_label.Size = new System.Drawing.Size(50, 25);
            this.INT_label.TabIndex = 3;
            this.INT_label.Text = "INT:";
            // 
            // END_label
            // 
            this.END_label.AutoSize = true;
            this.END_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.END_label.Location = new System.Drawing.Point(20, 144);
            this.END_label.Name = "END_label";
            this.END_label.Size = new System.Drawing.Size(59, 25);
            this.END_label.TabIndex = 2;
            this.END_label.Text = "END:";
            // 
            // DEX_label
            // 
            this.DEX_label.AutoSize = true;
            this.DEX_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEX_label.Location = new System.Drawing.Point(20, 92);
            this.DEX_label.Name = "DEX_label";
            this.DEX_label.Size = new System.Drawing.Size(59, 25);
            this.DEX_label.TabIndex = 1;
            this.DEX_label.Text = "DEX:";
            // 
            // STR_label
            // 
            this.STR_label.AutoSize = true;
            this.STR_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STR_label.Location = new System.Drawing.Point(20, 40);
            this.STR_label.Name = "STR_label";
            this.STR_label.Size = new System.Drawing.Size(58, 25);
            this.STR_label.TabIndex = 0;
            this.STR_label.Text = "STR:";
            // 
            // race_pictureBox
            // 
            this.race_pictureBox.Location = new System.Drawing.Point(12, 50);
            this.race_pictureBox.Name = "race_pictureBox";
            this.race_pictureBox.Size = new System.Drawing.Size(290, 262);
            this.race_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.race_pictureBox.TabIndex = 2;
            this.race_pictureBox.TabStop = false;
            // 
            // characterInformation_groupBox
            // 
            this.characterInformation_groupBox.Controls.Add(this.weight_textBox);
            this.characterInformation_groupBox.Controls.Add(this.height_textBox);
            this.characterInformation_groupBox.Controls.Add(this.age_textBox);
            this.characterInformation_groupBox.Controls.Add(this.name_textBox);
            this.characterInformation_groupBox.Controls.Add(this.weight_label);
            this.characterInformation_groupBox.Controls.Add(this.height_label);
            this.characterInformation_groupBox.Controls.Add(this.age_label);
            this.characterInformation_groupBox.Controls.Add(this.name_label);
            this.characterInformation_groupBox.Location = new System.Drawing.Point(14, 335);
            this.characterInformation_groupBox.Name = "characterInformation_groupBox";
            this.characterInformation_groupBox.Size = new System.Drawing.Size(288, 243);
            this.characterInformation_groupBox.TabIndex = 3;
            this.characterInformation_groupBox.TabStop = false;
            this.characterInformation_groupBox.Text = "Character Information";
            // 
            // weight_textBox
            // 
            this.weight_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_textBox.Location = new System.Drawing.Point(126, 191);
            this.weight_textBox.Name = "weight_textBox";
            this.weight_textBox.Size = new System.Drawing.Size(141, 30);
            this.weight_textBox.TabIndex = 7;
            this.weight_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_textBox_KeyPress);
            // 
            // height_textBox
            // 
            this.height_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_textBox.Location = new System.Drawing.Point(126, 141);
            this.height_textBox.Name = "height_textBox";
            this.height_textBox.Size = new System.Drawing.Size(141, 30);
            this.height_textBox.TabIndex = 6;
            this.height_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_textBox_KeyPress);
            // 
            // age_textBox
            // 
            this.age_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_textBox.Location = new System.Drawing.Point(126, 91);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.Size = new System.Drawing.Size(141, 30);
            this.age_textBox.TabIndex = 5;
            this.age_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_textBox_KeyPress);
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(126, 41);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(141, 30);
            this.name_textBox.TabIndex = 4;
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_label.Location = new System.Drawing.Point(22, 194);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(80, 25);
            this.weight_label.TabIndex = 3;
            this.weight_label.Text = "Weight:";
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_label.Location = new System.Drawing.Point(22, 143);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(74, 25);
            this.height_label.TabIndex = 2;
            this.height_label.Text = "Height:";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_label.Location = new System.Drawing.Point(22, 92);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(54, 25);
            this.age_label.TabIndex = 1;
            this.age_label.Text = "Age:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(22, 41);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(70, 25);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name:";
            // 
            // health_label
            // 
            this.health_label.AutoSize = true;
            this.health_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health_label.Location = new System.Drawing.Point(345, 526);
            this.health_label.Name = "health_label";
            this.health_label.Size = new System.Drawing.Size(74, 25);
            this.health_label.TabIndex = 6;
            this.health_label.Text = "Health:";
            // 
            // race_label
            // 
            this.race_label.AutoSize = true;
            this.race_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race_label.Location = new System.Drawing.Point(345, 475);
            this.race_label.Name = "race_label";
            this.race_label.Size = new System.Drawing.Size(63, 25);
            this.race_label.TabIndex = 5;
            this.race_label.Text = "Race:";
            // 
            // job_label
            // 
            this.job_label.AutoSize = true;
            this.job_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_label.Location = new System.Drawing.Point(345, 424);
            this.job_label.Name = "job_label";
            this.job_label.Size = new System.Drawing.Size(51, 25);
            this.job_label.TabIndex = 4;
            this.job_label.Text = "Job:";
            // 
            // health_textBox
            // 
            this.health_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health_textBox.Location = new System.Drawing.Point(425, 521);
            this.health_textBox.Name = "health_textBox";
            this.health_textBox.ReadOnly = true;
            this.health_textBox.Size = new System.Drawing.Size(152, 30);
            this.health_textBox.TabIndex = 9;
            // 
            // race_textBox
            // 
            this.race_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race_textBox.Location = new System.Drawing.Point(425, 471);
            this.race_textBox.Name = "race_textBox";
            this.race_textBox.ReadOnly = true;
            this.race_textBox.Size = new System.Drawing.Size(152, 30);
            this.race_textBox.TabIndex = 8;
            // 
            // job_textBox
            // 
            this.job_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_textBox.Location = new System.Drawing.Point(425, 421);
            this.job_textBox.Name = "job_textBox";
            this.job_textBox.ReadOnly = true;
            this.job_textBox.Size = new System.Drawing.Size(152, 30);
            this.job_textBox.TabIndex = 7;
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 658);
            this.ControlBox = false;
            this.Controls.Add(this.health_textBox);
            this.Controls.Add(this.race_textBox);
            this.Controls.Add(this.job_textBox);
            this.Controls.Add(this.health_label);
            this.Controls.Add(this.race_label);
            this.Controls.Add(this.job_label);
            this.Controls.Add(this.characterInformation_groupBox);
            this.Controls.Add(this.race_pictureBox);
            this.Controls.Add(this.Abilities_groupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FinalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Form";
            this.Load += new System.EventHandler(this.FinalForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Abilities_groupBox.ResumeLayout(false);
            this.Abilities_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.race_pictureBox)).EndInit();
            this.characterInformation_groupBox.ResumeLayout(false);
            this.characterInformation_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox Abilities_groupBox;
        private System.Windows.Forms.TextBox CHA_textBox;
        private System.Windows.Forms.TextBox PER_textBox;
        private System.Windows.Forms.TextBox INT_textBox;
        private System.Windows.Forms.TextBox END_textBox;
        private System.Windows.Forms.TextBox DEX_textBox;
        private System.Windows.Forms.TextBox STR_textBox;
        private System.Windows.Forms.Label CHA_label;
        private System.Windows.Forms.Label PER_label;
        private System.Windows.Forms.Label INT_label;
        private System.Windows.Forms.Label END_label;
        private System.Windows.Forms.Label DEX_label;
        private System.Windows.Forms.Label STR_label;
        private System.Windows.Forms.PictureBox race_pictureBox;
        private System.Windows.Forms.GroupBox characterInformation_groupBox;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox weight_textBox;
        private System.Windows.Forms.TextBox height_textBox;
        private System.Windows.Forms.TextBox age_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label health_label;
        private System.Windows.Forms.Label race_label;
        private System.Windows.Forms.Label job_label;
        private System.Windows.Forms.TextBox health_textBox;
        private System.Windows.Forms.TextBox race_textBox;
        private System.Windows.Forms.TextBox job_textBox;
    }
}