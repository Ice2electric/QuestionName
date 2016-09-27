using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionName
{
    public partial class frmOneQuestionQuiz : Form
    {
        public frmOneQuestionQuiz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_question_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton_false_CheckedChanged(object sender, EventArgs e)
        {
            
            {
                if (RadioButton_false.Checked)
                    MessageBox.Show("Wrong.");
               
               
            }
        }

        private void RadioButton_true_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_true.Checked)
                MessageBox.Show("Correct.");


        }

        private void radioButton_exit_CheckedChanged(object sender, EventArgs e)
        {
            int milliseconds = 2000;
            
            Thread.Sleep(milliseconds);
            MessageBox.Show("Have a nice Day.");
            Application.Exit();
        }

        
    }
}
