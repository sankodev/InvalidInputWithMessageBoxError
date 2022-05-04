using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC6_KS_InvalidInputWithMessageBoxError
{
    public partial class InputInvalidationForm : Form
    {
        public InputInvalidationForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //prep
            double exam1, exam2, finalExam, examAverage;
            //try parse
            if (!double.TryParse(exam1TextBox.Text, out exam1)|| exam1 <0 || exam1 > 90)
            {
               //show le messagebox
                MessageBox.Show("Score must be between 0 and 90.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //show label error
                exam1ErrorLabel.Show();
                examAverageLabel.Text = "Error";
                examAverageLabel.ForeColor = Color.Red;
                exam1TextBox.Focus();
                exam1TextBox.SelectAll();
                //tell the computer to stop
                return;
            }
            if (!double.TryParse(exam2TextBox.Text, out exam2) || exam2 < 0 || exam2 > 90)
            {
                //show le messagebox
                MessageBox.Show("Score must be between 0 and 90.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //show label error
                exam2ErrorLabel.Show();
                examAverageLabel.Text = "Error";
                examAverageLabel.ForeColor = Color.Red;
                exam1TextBox.Focus();
                exam1TextBox.SelectAll();
                //tell the computer to stop
                return;
            }
            if (!double.TryParse(finalExamTextBox.Text, out finalExam) || finalExam < 0 || finalExam > 120)
            {
                //show le messagebox
                MessageBox.Show("Score must be between 0 and 120.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //show label error
                finalExamErrorLabel.Show();
                examAverageLabel.Text = "Error";
                examAverageLabel.ForeColor = Color.Red;
                exam1TextBox.Focus();
                exam1TextBox.SelectAll();
                //tell the computer to stop
                return;
            }
            //process
            examAverage = (exam1 + exam2 + finalExam) / 300;
            //read exam ave as percentile
            examAverageLabel.Text = examAverage.ToString("P");
            exam1TextBox.Focus();
            exam1TextBox.SelectAll();
            //end
        }

        private void InputInvalidationForm_Load(object sender, EventArgs e)
        {
            exam1ErrorLabel.Hide();
            exam2ErrorLabel.Hide();
            finalExamErrorLabel.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            exam1TextBox.Clear();
            exam2TextBox.Clear();
            finalExamTextBox.Clear();
            examAverageLabel.Text = "";
            exam1ErrorLabel.Hide();
            exam2ErrorLabel.Hide();
            finalExamErrorLabel.Hide();
        }
    }
}
