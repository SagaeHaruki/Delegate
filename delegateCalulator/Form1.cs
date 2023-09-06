using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegateCalulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            CalculatorClass cal = new CalculatorClass();
            double total;

            string vars = cmb_bx.Text.ToString();
            if (vars == "+")
            {
                total = cal.Addtion(Convert.ToDouble(fn_bx.Text), Convert.ToDouble(sn_bx.Text));
                answer_box.Text = total.ToString();
            }
            else if (vars == "-")
            {
                total = cal.Subtract(Convert.ToDouble(fn_bx.Text), Convert.ToDouble(sn_bx.Text));
                answer_box.Text = total.ToString();
            }
            else if (vars == "*")
            {
                total = cal.Multiply(Convert.ToDouble(fn_bx.Text), Convert.ToDouble(sn_bx.Text));
                answer_box.Text = total.ToString();
            }
            else
            {
                total = cal.Divide(Convert.ToDouble(fn_bx.Text), Convert.ToDouble(sn_bx.Text));
                answer_box.Text = total.ToString();
            }


        }
    }

    class CalculatorClass
    {
        public delegate T Information<T>(T args);
        public Information<String> info;

        public double Addtion(double x, double y)
        {
            return x + y;
        }
        public double Subtract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)  
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                MessageBox.Show("Cannot be divided by zero");
            }
            return x / y;
        }
    }
}
