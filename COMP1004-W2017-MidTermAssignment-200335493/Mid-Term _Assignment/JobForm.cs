using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid_Term__Assignment
{
    public partial class JobForm : Form
    {
        private static int _health;
        private static string _job;
        public JobForm()
        {
            InitializeComponent();
        }

        // set the health variable
        private void setHealthPoints(int pts)
        {
            _health = pts;
        }

        // get the health value
        public static int getHealthPoints()
        {
            return _health;
        }

        // set the job variable
        private void setJob(string j)
        {
            _job = j;
        }

        // get the job value
        public static string getJob()
        {
            return _job;
        }

        // when the soldier radio button is clicked
        private void soldier_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            health_label.Text = "Health Points: " + (30 + AbilityForm.getEND());
            setHealthPoints(30 + AbilityForm.getEND());
            setJob("Soldier");
        }

        // when the rogue radio button is clicked
        private void rogue_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            health_label.Text = "Health Points: " + (28 + AbilityForm.getDEX());
            setHealthPoints(28 + AbilityForm.getDEX());
            setJob("Rogue");
        }

        // when the magicker radio button is clicked
        private void magicker_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            health_label.Text = "Health Points: " + (15 + AbilityForm.getINT());
            setHealthPoints(15 + AbilityForm.getINT());
            setJob("Magicker");
        }

        // when the cultist radio button is clicked
        private void cultist_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            health_label.Text = "Health Points: " + (24 + AbilityForm.getCHA());
            setHealthPoints(24 + AbilityForm.getCHA());
            setJob("Cultist");
        }

        // open the FinalForm form and hide this form when the next button is clicked
        private void next_button_Click(object sender, EventArgs e)
        {
            FinalForm ff = new FinalForm();
            ff.Show();
            Hide();
        }
    }
}
