using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RegisterAppForms.StudentInfoClass;
using RegisterAppForms;

namespace RegisterAppForms
{
    public partial class Form2 : Form
    {
        private Func<string, string> DelProgram;
        private Func<string, string> DelFname;
        private Func<string, string> DelLname;
        private Func<string, string> DelMname;
        private Func<string, string> DelAddrs;
        private Func<long, long> DelNumAge;
        private Func<long, long> DelNumContactNo;
        private Func<long, long> DelStudNo;

        public Form2()
        {
            InitializeComponent();
            DelProgram = StudentInfoClass.GetProgram;
            DelFname = StudentInfoClass.GetFirstName;
            DelLname = StudentInfoClass.GetLastName;
            DelMname = StudentInfoClass.GetMiddleName;
            DelAddrs = StudentInfoClass.GetAddress;
            DelNumAge = StudentInfoClass.GetAge;
            DelNumContactNo = StudentInfoClass.GetContactNo;
            DelStudNo = StudentInfoClass.GetStudentNo;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pg_tb.Text = DelProgram(StudentInfoClass.prog);
            ag_tb.Text = DelNumAge(StudentInfoClass.age).ToString();
            sn_tb.Text = DelStudNo(StudentInfoClass.std_num).ToString();
            cnt_tb.Text = DelStudNo(StudentInfoClass.contact).ToString();
            fn_tb.Text = DelFname(StudentInfoClass.fname);
            ln_tb.Text = DelFname(StudentInfoClass.lname);
            mn_tb.Text = DelFname(StudentInfoClass.mname);
            add_tb.Text = DelFname(StudentInfoClass.addrs);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
