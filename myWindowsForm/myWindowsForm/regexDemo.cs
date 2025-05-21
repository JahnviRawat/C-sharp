using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWindowsForm
{
    public partial class regexDemo : Form
    {
        public regexDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // only numbers
            var res = Regex.IsMatch(textBox1.Text, "^[0-9]+$");
            if (res == true) { 
                label1.Text = res + ": " + textBox1.Text;
            }
            else
            {
                label1.Text = res +  ": Invalid Expression";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // only alphabets
            var res = Regex.IsMatch(textBox1.Text, "^[a-z]+$",RegexOptions.IgnoreCase);
            if (res == true)
            {
                label1.Text = "Valid Expression: " + textBox1.Text;
            }
            else
            {
                label1.Text =  " Invalid Expression";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var res = Regex.IsMatch(textBox1.Text, "^\\S+$");
            if (res == true)
            {
                label1.Text = "Valid Expression: " + textBox1.Text;
            }
            else
            {
                label1.Text = " Invalid Expression";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var res = Regex.IsMatch(textBox1.Text, "^[a-zA-Z0-9]+$");
            if (res == true)
            {
                label1.Text = "Valid Expression: " + textBox1.Text;
            }
            else
            {
                label1.Text = " Invalid Expression";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var res = Regex.Match(textBox1.Text, @"\d+");
            if (res.Success == true) {
                label1.Text = res.Value;
            }
            else
            {
                label1.Text = "Not found";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var res = Regex.Matches(textBox1.Text, @"\d+");

            foreach (Match match in res) {

                if (match.Success == true)
                {
                    label1.Text += match.Value + "\n";
                }
                else
                {
                    label1.Text = "Not found";
                }
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            var res = Regex.Match(textBox1.Text, @"^[a-z]{3}[-][a-z]{4}",RegexOptions.IgnoreCase);
            if (res.Success == true)
            {
                label1.Text = res.Value;
            }
            else
            {
                label1.Text = "Invalid Expression";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var res = Regex.IsMatch(textBox1.Text, "^[a-zA-Z]+[@]{1}[a-z]+[.]{1}[a-z]+$");
            //label1.Text = res.ToString();
            if (res == true)
            {
                label1.Text = "valid email";
            }
            else
            {
                label1.Text = "Invalid email";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            var str = Regex.Replace(textBox1.Text, @"\d", "morvi");
            label1.Text = str;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //var res = textBox1.Text.Split(';','-','@');

            var res = Regex.Split(textBox1.Text, @"[,;|@]");

            foreach (var item in res) { label1.Text += item + "\n"; }
        }
    }
}
