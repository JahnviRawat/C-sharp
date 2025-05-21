using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWindowsForm
{
    public partial class Form2 : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) {
                errorProvider.SetError(textBox1, "Enter UserName");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                errorProvider.SetError(textBox3, "Password Does Not Match");
            } else
            {
                errorProvider.Clear();
            }

     

            string str = "";
            str += label1.Text + ": " + textBox1.Text + "\n";
            str += label2.Text + ": " + textBox2.Text + "\n";
            if (radioButton1.Checked) {
                str += label4.Text + ": " + radioButton1.Text + "\n";
            }
            else
            {
                str += label4.Text + ": " + radioButton2.Text + "\n";
            }

            str += label5.Text + ": " + dateTimePicker1.Text + "\n";
            str += label6.Text + ": " + comboBox1.Text + "\n";
            str += label7.Text + ": " + listBox1.Text + "\n" +  label9.Text + " : ";

            if (checkBox1.Checked)
            {
                str += checkBox1.Text + "\n";
            }
            if (checkBox2.Checked)
            {
                str += checkBox2.Text + "\n";
            }
            if (checkBox3.Checked)
            {
                str += checkBox3.Text + "\n";
            }
            if (checkBox4.Checked)
            {
                str += checkBox4.Text + "\n";
            }
            
            Form4 form4 = new Form4();
            form4.ShowDialog();
            //this.Close();
            this.Hide();



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
