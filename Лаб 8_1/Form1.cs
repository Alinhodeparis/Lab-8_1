using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб_8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double probability = 0.5;

        Random rnd = new Random();

        string text;

        private void btAnswer_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;

            if (text.Length == 0)
            {
                labelAnswer.Text = "Ask a question!";
                labelAnswer.Location = new Point(110, 95);
                return;
            }

            if (rnd.NextDouble() < probability)
            {
                labelAnswer.Text = "Yes!";
                labelAnswer.Location = new Point(250, 150);
            }
            else
            {
                labelAnswer.Text = " No!";
                labelAnswer.Location = new Point(250, 150);
            }
        }
    }
}
