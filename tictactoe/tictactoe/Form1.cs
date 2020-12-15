using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        int playerStatus = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button2.Text = "O";
                playerStatus = 1;
                button2.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button2.Text = "X";
                playerStatus = 0;
                button2.Enabled = false;
            }
            check();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button1.Text = "O";
                playerStatus = 1;
                button1.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button1.Text = "X";
                playerStatus = 0;
                button1.Enabled = false;
            }
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button3.Text = "O";
                playerStatus = 1;
                button3.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button3.Text = "X";
                playerStatus = 0;
                button3.Enabled = false;
            }
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button4.Text = "O";
                playerStatus = 1;
                button4.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button4.Text = "X";
                playerStatus = 0;
                button4.Enabled = false;
            }
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button5.Text = "O";
                playerStatus = 1;
                button5.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button5.Text = "X";
                playerStatus = 0;
                button5.Enabled = false;
            }
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button6.Text = "O";
                playerStatus = 1;
                button6.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button6.Text = "X";
                playerStatus = 0;
                button6.Enabled = false;
            }
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button7.Text = "O";
                playerStatus = 1;
                button7.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button7.Text = "X";
                playerStatus = 0;
                button7.Enabled = false;
            }
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button8.Text = "O";
                playerStatus = 1;
                button8.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button8.Text = "X";
                playerStatus = 0;
                button8.Enabled = false;
            }
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0) 
            {
                button9.Text = "O";
                playerStatus = 1;
                button9.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button9.Text = "X";
                playerStatus = 0;
                button9.Enabled = false;
            }
            check();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void check()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.LightBlue;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.LightBlue;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.LightBlue;
                    button3.ForeColor = Color.White;
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        
                    }
                }
            }
            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    button1.BackColor = Color.LightBlue;
                    button1.ForeColor = Color.White;
                    button4.BackColor = Color.LightBlue;
                    button4.ForeColor = Color.White;
                    button7.BackColor = Color.LightBlue;
                    button7.ForeColor = Color.White;
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                }
            }
            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    button2.BackColor = Color.LightBlue;
                    button2.ForeColor = Color.White;
                    button5.BackColor = Color.LightBlue;
                    button5.ForeColor = Color.White;
                    button8.BackColor = Color.LightBlue;
                    button8.ForeColor = Color.White;
                    if (button2.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                }
            }

            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    button3.BackColor = Color.LightBlue;
                    button3.ForeColor = Color.White;
                    button6.BackColor = Color.LightBlue;
                    button6.ForeColor = Color.White;
                    button9.BackColor = Color.LightBlue;
                    button9.ForeColor = Color.White;
                    if (button3.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                }
            }

            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    button4.BackColor = Color.LightBlue;
                    button4.ForeColor = Color.White;
                    button5.BackColor = Color.LightBlue;
                    button5.ForeColor = Color.White;
                    button6.BackColor = Color.LightBlue;
                    button6.ForeColor = Color.White;
                    if (button4.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                }
            }

            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    button7.BackColor = Color.LightBlue;
                    button7.ForeColor = Color.White;
                    button8.BackColor = Color.LightBlue;
                    button8.ForeColor = Color.White;
                    button9.BackColor = Color.LightBlue;
                    button9.ForeColor = Color.White;
                    if (button7.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                }
            }

            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    button1.BackColor = Color.LightBlue;
                    button1.ForeColor = Color.White;
                    button5.BackColor = Color.LightBlue;
                    button5.ForeColor = Color.White;
                    button9.BackColor = Color.LightBlue;
                    button9.ForeColor = Color.White;
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                }
            }

            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    button3.BackColor = Color.LightBlue;
                    button3.ForeColor = Color.White;
                    button5.BackColor = Color.LightBlue;
                    button5.ForeColor = Color.White;
                    button7.BackColor = Color.LightBlue;
                    button7.ForeColor = Color.White;
                    if (button3.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                }
            }
        }
        
    }
}
