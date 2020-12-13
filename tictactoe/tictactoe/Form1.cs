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
        }
    }
}
