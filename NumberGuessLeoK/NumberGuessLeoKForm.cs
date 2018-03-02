using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessLeoK
{
    public partial class frmNumberGuess : Form
    {
        public frmNumberGuess()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //local variables
            const int NUM_SECRET = 9;
            int numGuess;

            //Get the number from the textbox
            numGuess = int.Parse(txtInput.Text);

            //If the user gets it right, display a checkmark and play a ding sound
            //If the user gets it wrong, display a X and play a wrong sound

            if (numGuess == NUM_SECRET)
            {
                this.picRightOrWrong.Image = Properties.Resources.checkmark;
                System.Media.SoundPlayer dingSound = new System.Media.SoundPlayer(@"n:\StuShare\Semester 2 - Winter 2018\ICS3U Programming\Kay, Leo (s240457)\Unit 3 (Decisions)\NumberGuessLeoK\Correct_Answer_Sound_Effect.wav");
                dingSound.Play();
            }
            else
            {
                this.picRightOrWrong.Image = Properties.Resources.red_x;
                System.Media.SoundPlayer wrongSound = new System.Media.SoundPlayer(@"n:\StuShare\Semester 2 - Winter 2018\ICS3U Programming\Kay, Leo (s240457)\Unit 3 (Decisions)\NumberGuessLeoK\Wrong_Buzzer_Sound_Effect.wav");
                wrongSound.Play();
            }
        }
    }
}
