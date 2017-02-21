namespace Mid_Term__Assignment
{
    partial class JobForm
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
            this.job_groupBox = new System.Windows.Forms.GroupBox();
            this.soldier_radioButton = new System.Windows.Forms.RadioButton();
            this.rogue_radioButton = new System.Windows.Forms.RadioButton();
            this.magicker_radioButton = new System.Windows.Forms.RadioButton();
            this.cultist_radioButton = new System.Windows.Forms.RadioButton();
            this.health_label = new System.Windows.Forms.Label();
            this.next_button = new System.Windows.Forms.Button();
            this.job_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // job_groupBox
            // 
            this.job_groupBox.Controls.Add(this.cultist_radioButton);
            this.job_groupBox.Controls.Add(this.magicker_radioButton);
            this.job_groupBox.Controls.Add(this.rogue_radioButton);
            this.job_groupBox.Controls.Add(this.soldier_radioButton);
            this.job_groupBox.Location = new System.Drawing.Point(33, 33);
            this.job_groupBox.Name = "job_groupBox";
            this.job_groupBox.Size = new System.Drawing.Size(180, 201);
            this.job_groupBox.TabIndex = 0;
            this.job_groupBox.TabStop = false;
            this.job_groupBox.Text = "Job";
            // 
            // soldier_radioButton
            // 
            this.soldier_radioButton.AutoSize = true;
            this.soldier_radioButton.Location = new System.Drawing.Point(21, 34);
            this.soldier_radioButton.Name = "soldier_radioButton";
            this.soldier_radioButton.Size = new System.Drawing.Size(83, 24);
            this.soldier_radioButton.TabIndex = 0;
            this.soldier_radioButton.TabStop = true;
            this.soldier_radioButton.Text = "Soldier";
            this.soldier_radioButton.UseVisualStyleBackColor = true;
            this.soldier_radioButton.CheckedChanged += new System.EventHandler(this.soldier_radioButton_CheckedChanged);
            // 
            // rogue_radioButton
            // 
            this.rogue_radioButton.AutoSize = true;
            this.rogue_radioButton.Location = new System.Drawing.Point(21, 68);
            this.rogue_radioButton.Name = "rogue_radioButton";
            this.rogue_radioButton.Size = new System.Drawing.Size(82, 24);
            this.rogue_radioButton.TabIndex = 1;
            this.rogue_radioButton.TabStop = true;
            this.rogue_radioButton.Text = "Rogue";
            this.rogue_radioButton.UseVisualStyleBackColor = true;
            this.rogue_radioButton.CheckedChanged += new System.EventHandler(this.rogue_radioButton_CheckedChanged);
            // 
            // magicker_radioButton
            // 
            this.magicker_radioButton.AutoSize = true;
            this.magicker_radioButton.Location = new System.Drawing.Point(21, 102);
            this.magicker_radioButton.Name = "magicker_radioButton";
            this.magicker_radioButton.Size = new System.Drawing.Size(98, 24);
            this.magicker_radioButton.TabIndex = 2;
            this.magicker_radioButton.TabStop = true;
            this.magicker_radioButton.Text = "Magicker";
            this.magicker_radioButton.UseVisualStyleBackColor = true;
            this.magicker_radioButton.CheckedChanged += new System.EventHandler(this.magicker_radioButton_CheckedChanged);
            // 
            // cultist_radioButton
            // 
            this.cultist_radioButton.AutoSize = true;
            this.cultist_radioButton.Location = new System.Drawing.Point(21, 136);
            this.cultist_radioButton.Name = "cultist_radioButton";
            this.cultist_radioButton.Size = new System.Drawing.Size(78, 24);
            this.cultist_radioButton.TabIndex = 3;
            this.cultist_radioButton.TabStop = true;
            this.cultist_radioButton.Text = "Cultist";
            this.cultist_radioButton.UseVisualStyleBackColor = true;
            this.cultist_radioButton.CheckedChanged += new System.EventHandler(this.cultist_radioButton_CheckedChanged);
            // 
            // health_label
            // 
            this.health_label.AutoSize = true;
            this.health_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health_label.Location = new System.Drawing.Point(219, 42);
            this.health_label.Name = "health_label";
            this.health_label.Size = new System.Drawing.Size(175, 29);
            this.health_label.TabIndex = 1;
            this.health_label.Text = "Health Points:";
            // 
            // next_button
            // 
            this.next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.Location = new System.Drawing.Point(233, 248);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(161, 53);
            this.next_button.TabIndex = 4;
            this.next_button.TabStop = false;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 329);
            this.ControlBox = false;
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.health_label);
            this.Controls.Add(this.job_groupBox);
            this.MaximumSize = new System.Drawing.Size(470, 385);
            this.MinimumSize = new System.Drawing.Size(470, 385);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Form";
            this.job_groupBox.ResumeLayout(false);
            this.job_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox job_groupBox;
        private System.Windows.Forms.RadioButton cultist_radioButton;
        private System.Windows.Forms.RadioButton magicker_radioButton;
        private System.Windows.Forms.RadioButton rogue_radioButton;
        private System.Windows.Forms.RadioButton soldier_radioButton;
        private System.Windows.Forms.Label health_label;
        private System.Windows.Forms.Button next_button;
    }
}