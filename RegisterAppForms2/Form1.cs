using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterAppForms
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            bool contact = bx_cnt.Text.Any(Char.IsLetter);
            bool stud_num = bx_std.Text.Any(Char.IsLetter);
            bool ages = bx_ag.Text.Any(Char.IsLetter);
            bool contact2 = bx_cnt.Text.All(Char.IsLetter);
            bool stud_num2 = bx_std.Text.All(Char.IsLetter);
            bool ages2 = bx_ag.Text.All(Char.IsLetter);
            if (contact == true)
            {
                MessageBox.Show("Contact number cannot contain any letter");
            }
            else if (stud_num == true)
            {
                MessageBox.Show("Student number cannot contain any letter");
            }
            else if (ages == true)
            {
                MessageBox.Show("Age cannot contain any letter");
            }
            else if (contact2 == true || stud_num2 == true || ages2 == true)
            {
                MessageBox.Show("Please fill up the empty boxes");
            }
            else
            {
                StudentInfoClass.fname = bx_fn.Text.ToString();
                StudentInfoClass.lname = bx_ln.Text.ToString();
                StudentInfoClass.mname = bx_mn.Text.ToString();
                StudentInfoClass.addrs = bx_adrs.Text.ToString();
                StudentInfoClass.prog = cbx_crs.Text.ToString();
                StudentInfoClass.age = (long)Convert.ToDouble(bx_ag.Text);
                StudentInfoClass.contact = (long)Convert.ToDouble(bx_cnt.Text);
                StudentInfoClass.std_num = (long)Convert.ToDouble(bx_std.Text);

                Form2 fmr = new Form2();
                if (fmr.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
    public class StudentInfoClass
    {
        public delegate void DelegateNumber(long number);
        public delegate void DelegateText(string txt);

        public static string fname = "";
        public static string lname = "";
        public static string mname = "";
        public static string addrs = "";
        public static string prog = "";
        public static long age;
        public static long contact;
        public static long std_num;

        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }

        public static string GetLastName(string LastName)
        {
            return LastName;
        }

        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }

        public static string GetProgram(string Program)
        {
            return Program;
        }

        public static string GetAddress(string Address)
        {
            return Address;
        }

        public static long GetAge(long Age)
        {
            return Age;
        }

        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }

        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }


    }
}
