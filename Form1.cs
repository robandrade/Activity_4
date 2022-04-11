using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int seconds;
            int hours;
            int minutes;
            int days;

            seconds = int.Parse(secondsEntered.Text); 

            if (seconds >= 60)
            {
                minutes = seconds / 60;

                secondsSolution.Text = minutes + " minutes";
            }

        }

        private void secondsSolution_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondsEntered_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
