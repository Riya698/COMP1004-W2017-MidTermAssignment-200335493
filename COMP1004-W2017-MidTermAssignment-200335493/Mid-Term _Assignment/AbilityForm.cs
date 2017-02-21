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
    public partial class AbilityForm : Form
    {
        private static int _str, _dex, _end, _int, _per, _cha;
        public AbilityForm()
        {
            InitializeComponent();
        }

        // generate random number between 3 to 30
        private int Roll3D10()
        {
            int number = 0, i = 1;
            Random rnd = new Random();
            while (i <= 3)
            {
                number += rnd.Next(1, 11);
                i++;
            }
            return number;

        }
        
        // when the roll button is clicked
        private void roll_button_Click(object sender, EventArgs e)
        {
            STR_textBox.Text = Roll3D10().ToString();
            DEX_textBox.Text = Roll3D10().ToString();
            END_textBox.Text = Roll3D10().ToString();
            INT_textBox.Text = Roll3D10().ToString();
            PER_textBox.Text = Roll3D10().ToString();
            CHA_textBox.Text = Roll3D10().ToString();
            setAbilitiesValues();
        }

        // set all the abilities variables
        private void setAbilitiesValues()
        {
            _str = int.Parse(STR_textBox.Text);
            _dex = int.Parse(DEX_textBox.Text);
            _end = int.Parse(END_textBox.Text);
            _int = int.Parse(INT_textBox.Text);
            _per = int.Parse(PER_textBox.Text);
            _cha = int.Parse(CHA_textBox.Text);
        }

        // set the STR ability
        public static void setSTR(int number)
        {
            _str = number;
        }

        // set the DEX ability
        public static void setDEX(int number)
        {
            _dex = number;
        }

        // set the ENT ability
        public static void setEND(int number)
        {
            _end = number;
        }

        // set the INT ability
        public static void setINT(int number)
        {
            _int = number;
        }

        // set the PER ability
        public static void setPER(int number)
        {
            _per = number;
        }

        // set the CHA ability
        public static void setCHA(int number)
        {
            _cha = number;
        }

        // return the STR ability value
        public static int getSTR()
        {
            return _str;
        }

        // return the DEX ability value
        public static int getDEX()
        {
            return _dex;
        }

        // if the user closed the form not through the exit button
        private void AbilityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // return the END ability value
        public static int getEND()
        {
            return _end;
        }

        // return the INT ability value
        public static int getINT()
        {
            return _int;
        }

        // return the PER ability value
        public static int getPER()
        {
            return _per;
        }

        // return the CHA ability value
        public static int getCHA()
        {
            return _cha;
        }

        // open the RaceForm form and hide this form when the next button is clicked
        private void next_button_Click(object sender, EventArgs e)
        {
            if (!STR_textBox.Text.Equals(""))
            {
                RaceForm rf = new RaceForm();
                rf.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please press the roll button first", "Error");
            }
        }
    }
}
