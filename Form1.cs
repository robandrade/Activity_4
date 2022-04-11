using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            int seconds;
            int minutes;
            int hours;
            int days;

            seconds = int.Parse(secondsEntered.Text);

            if (seconds >= 60 && seconds <= 3599)
            {
                minutes = seconds / 60;

                secondsSolution.Text = minutes.ToString() + " minutes";
            }
            else if (seconds >= 3600 && seconds <= 86399)
            {
                hours = seconds / 3600;

                secondsSolution.Text = hours.ToString() + " hours";
            }
            else if (seconds <= 59)
            {
                secondsSolution.Text = seconds.ToString() + " seconds";
            }
            else if (seconds >= 86400)
            {
                days = seconds / 86400;

                secondsSolution.Text = days.ToString() + " days";
            }
        }

        private void secondsEntered_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondsSolution_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
