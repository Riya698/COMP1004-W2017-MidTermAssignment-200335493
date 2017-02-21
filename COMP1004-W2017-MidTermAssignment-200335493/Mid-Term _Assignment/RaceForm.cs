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
    public partial class RaceForm : Form
    {
        private static string _race;
        Image human = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\M_Human1.png");
        Image dwarf = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\M_Dwarf1.png");
        Image elf = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\M_Elf1.png");
        Image halfling = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\M_Halfling2.png");
        public RaceForm()
        {
            InitializeComponent();
        }

        // open the JobForm form and hide this form when the next button is clicked
        private void next_button_Click(object sender, EventArgs e)
        {
            JobForm jf = new JobForm();
            jf.Show();
            Hide();
        }

        // set the the value of the race variable
        private void setRace(string r)
        {
            _race = r;
        }

        // return the race value
        public static string getRace()
        {
            return _race;
        }

        // when the human radio button is clicked
        private void human_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            setRace("Human");
            racialBonus_textBox.Text = "All of your abilities will be increased by 5 pts.";
            race_pictureBox.Image = human;
            AbilityForm.setSTR(AbilityForm.getSTR() + 5);
            AbilityForm.setDEX(AbilityForm.getDEX() + 5);
            AbilityForm.setEND(AbilityForm.getEND() + 5);
            AbilityForm.setINT(AbilityForm.getINT() + 5);
            AbilityForm.setPER(AbilityForm.getPER() + 5);
            AbilityForm.setCHA(AbilityForm.getCHA() + 5);
        }

        // when the dwarf radio button is clicked
        private void dwarf_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            setRace("Dwarf");
            racialBonus_textBox.Text = "STR and	PER increased by 20 pts, CHA decreased by 10 pts.";
            race_pictureBox.Image = dwarf;
            AbilityForm.setSTR(AbilityForm.getSTR() + 20);
            AbilityForm.setPER(AbilityForm.getPER() + 20);

            if (AbilityForm.getCHA() >= 13)
                AbilityForm.setCHA(AbilityForm.getCHA() - 10);
            else
                AbilityForm.setCHA(3);
        }

        // when the elf radio button is clicked
        private void elf_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            setRace("Elf");
            racialBonus_textBox.Text = "	DEX and	CHA increased by 15 pts.";
            race_pictureBox.Image = elf;
            AbilityForm.setDEX(AbilityForm.getDEX() + 15);
            AbilityForm.setCHA(AbilityForm.getCHA() + 15);
        }

        // when the halfling radio button is clicked
        private void halfling_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            setRace("Halfling");
            racialBonus_textBox.Text = "	DEX and	INT increased by 20 pts,STR decreased by 10 pts";
            race_pictureBox.Image = halfling;
            AbilityForm.setDEX(AbilityForm.getDEX() + 20);
            AbilityForm.setINT(AbilityForm.getINT() + 20);

            if (AbilityForm.getSTR() >= 13)
                AbilityForm.setSTR(AbilityForm.getSTR() - 10);
            else
                AbilityForm.setSTR(3);
        }
    }
}
