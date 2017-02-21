using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Mid Term Assignment- Character Generator	
// Made by Riya Patel
// Student # 200335493
// Created on February 21st 2017	
// a project that generates	the	first few pages of an RPG character

namespace Mid_Term__Assignment

{
    public partial class FinalForm : Form
    {
        Image human = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\M_Human1.png");
        Image dwarf = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\M_Dwarf1.png");
        Image elf = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\M_Elf1.png");
        Image halfling = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\M_Halfling2.png");

        public FinalForm()
        {
            InitializeComponent();
        }

        // open the about box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        // close the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // change the font size between 10 to 18 points
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.MinSize = 10;
            fd.MaxSize = 18;
            DialogResult dr = fd.ShowDialog();
            name_textBox.Font = fd.Font;
            age_textBox.Font = fd.Font;
            height_textBox.Font = fd.Font;
            weight_textBox.Font = fd.Font;
        }

        // when the print item is clicked
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The character details has been sent to the printer", "Printing");
        }

        // get all the values that previously added
        private void FinalForm_Load(object sender, EventArgs e)
        {
            STR_textBox.Text = AbilityForm.getSTR().ToString();
            DEX_textBox.Text = AbilityForm.getDEX().ToString();
            END_textBox.Text = AbilityForm.getEND().ToString();
            INT_textBox.Text = AbilityForm.getINT().ToString();
            PER_textBox.Text = AbilityForm.getPER().ToString();
            CHA_textBox.Text = AbilityForm.getCHA().ToString();
            job_textBox.Text = JobForm.getJob();
            race_textBox.Text = RaceForm.getRace();
            health_textBox.Text = JobForm.getHealthPoints().ToString();

            if (race_textBox.Text.Equals("Human"))
                race_pictureBox.Image = human;
            else if (race_textBox.Text.Equals("Dwarf"))
                race_pictureBox.Image = dwarf;
            else if (race_textBox.Text.Equals("Elf"))
                race_pictureBox.Image = elf;
            else
                race_pictureBox.Image = halfling;
        }

        // just digits and one decimal point
        private void age_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // if the user closed the form not through the exit button
        public void FinalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
