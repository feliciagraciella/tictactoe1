using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            labelNama.Font = new Font("Arial", 10, FontStyle.Italic);
            labelNama.Text = textBoxNama.Text;
            comboBoxNama.Items.Add(textBoxNama.Text);
            listBoxNama.Items.Add(textBoxNama.Text);
        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }
    }
}
