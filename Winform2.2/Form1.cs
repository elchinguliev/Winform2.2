using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            double first=Convert.ToDouble(firstTextBox.Text); 
            double second=Convert.ToDouble(secondTextBox.Text);
            double result=first+second;
            rresultLbl.Text=result.ToString(); 
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(firstTextBox.Text);
            double second = Convert.ToDouble(secondTextBox.Text);
            double result = first-second;
            rresultLbl.Text=result.ToString();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(firstTextBox.Text);
            double second = Convert.ToDouble(secondTextBox.Text);
            double result = first*second;
            rresultLbl.Text=result.ToString();
        }

        private void divison_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(firstTextBox.Text);
            double second = Convert.ToDouble(secondTextBox.Text);
            double result = first/second;
            rresultLbl.Text=result.ToString();
        }

   
    }
}
