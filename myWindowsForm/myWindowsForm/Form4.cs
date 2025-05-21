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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "admin" && textBox2.Text == "123")
            {
                MyNotepad ob = new MyNotepad();
                //ob.Show();   //modless dialog box (togging is possible)
                ob.ShowDialog();  // act as a dialog box
                //this.Close();
                this.Hide();
            }
            else
            {
                //MessageBox.Show("Invalid User");
                var a = MessageBox.Show("Wrong Username or Password", "invalid User",MessageBoxButtons.OKCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                //MessageBox.Show(a.ToString());

                if(a.ToString() == "OK")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    //this.Close();
                    
                    this.Hide();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
