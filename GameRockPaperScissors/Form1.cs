using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRockPaperScissors
{
    public partial class Form1 : Form
    {
        enum Options { Rock, Paper, Scissors };
        enum Result { Player1, Computer, Draw };
        Options player1 = new Options();
        Options computer = new Options();
        Random rdm = new Random();
        Result winner = new Result();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            player1 = Options.Rock;
            OptionsPlayer();
            OptionsComputer();
            ResultWinner();
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            player1 = Options.Paper;
            OptionsPlayer();
            OptionsComputer();
            ResultWinner();
        }

        private void BtnScissors_Click(object sender, EventArgs e)
        {
            player1 = Options.Scissors;
            OptionsPlayer();
            OptionsComputer();
            ResultWinner();
        }
        void OptionsPlayer()
        {
            switch (player1)
            {
                case Options.Rock:
                    imgPlayer1.BackgroundImage = Image.FromFile
                        ("C:\\Repositories\\GameRockPaperScissors\\GameRockPaperScissors\\Resources\\rock.png");
                    break;
                case Options.Paper:
                    imgPlayer1.BackgroundImage = Image.FromFile
                        ("c:\\Repositories\\GameRockPaperScissors\\GameRockPaperScissors\\Resources\\Paper.png");
                    break;
                case Options.Scissors:
                    imgPlayer1.BackgroundImage = Image.FromFile
                        ("c:\\Repositories\\GameRockPaperScissors\\GameRockPaperScissors\\Resources\\Scissors.png");
                    break;
            }
        }
        void OptionsComputer()
        {
            int num = rdm.Next(1, 3);

            if (num == 1)
            {
                computer = Options.Rock;
                imgCPU.BackgroundImage = Image.FromFile
                    ("c:\\Repositories\\GameRockPaperScissors\\GameRockPaperScissors\\Resources\\Rock.png");
            }
            if (num == 2)
            {
                computer = Options.Paper;
                imgCPU.BackgroundImage = Image.FromFile
                    ("c:\\Repositories\\GameRockPaperScissors\\GameRockPaperScissors\\Resources\\Paper.png");
            }
            if (num == 3)
            {
                computer = Options.Scissors;
                imgCPU.BackgroundImage = Image.FromFile
                    ("c:\\Repositories\\GameRockPaperScissors\\GameRockPaperScissors\\Resources\\Scissors.png");
            }

        }

        void ResultWinner()
        {
            switch (player1)
            {
                case Options.Rock:
                    if (computer == Options.Rock)
                        winner = Result.Draw;
                    else if (computer == Options.Paper)
                        winner = Result.Computer;
                    else if (computer == Options.Scissors)
                        winner = Result.Player1;
                    break;

                case Options.Paper:
                    if (computer == Options.Rock)
                        winner = Result.Player1;
                    else if (computer == Options.Paper)
                        winner = Result.Draw;
                    else if (computer == Options.Scissors)
                        winner = Result.Computer;
                    break;

                case Options.Scissors:
                    if (computer == Options.Rock)
                        winner = Result.Computer;
                    else if (computer == Options.Paper)
                        winner = Result.Player1;
                    else if (computer == Options.Scissors)
                        winner = Result.Draw;
                    break;
            }

            if (winner == Result.Player1)
            {
                grpResult.BackColor = Color.LightBlue;
                plcPlayer1.Text = (int.Parse(plcPlayer1.Text) + 1).ToString();
                txtResultado.Text = "WINNER PLAYER 1";
            }
            if (winner == Result.Computer)
            {
                grpResult.BackColor = Color.LightPink;
                plcComputer.Text = (int.Parse(plcComputer.Text) + 1).ToString();
                txtResultado.Text = "WINNER COMPUTER";
            }
            if (winner == Result.Draw)
            {
                grpResult.BackColor = Color.LightYellow;
                txtResultado.Text = "DRAW";
            }
        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Rock wins Scissors, Paper wins Rock and Scissors wins Paper");
            return;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            plcPlayer1.Text = ("0");
            plcComputer.Text = ("0");
            grpResult.BackColor = Color.LightGray;
            txtResultado.Text = ("");
        }

        private void ImgPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void ImgPlayer_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ImgPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void ImgPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImgCPU_Enter(object sender, EventArgs e)
        {

        }
    }
}