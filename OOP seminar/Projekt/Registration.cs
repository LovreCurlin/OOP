using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            }
            else 
            { 
            Login main = new Login();
            main.Show();
            }
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
            {
                create();
                this.Hide();
                Login main = new Login();
                main.Show();
            }
        }
        public void create()
        {
            string gender;
            if (radioButton1.Checked)
                gender = radioButton1.Text;
            else
                gender = radioButton2.Text;

            string newUserTXT = textBox1.Text + ";" + textBox2.Text + ";" + dateTimePicker1.Text + ";" + gender + ";" + textBox4.Text + ";" + textBox5.Text;

            User newr = new User(textBox1.Text, textBox2.Text, dateTimePicker1.Value, gender, textBox4.Text, textBox5.Text);
            newr.CreateUserFolder();
            File.WriteAllText(Path.Combine(newr.FolderPath, "PersonalData.txt"), newUserTXT);
        }
        private bool check()
        { bool flag = true;
            if (string.IsNullOrEmpty(textBox1.Text))
            { 
                errorProvider1.SetError(textBox1, "ERROR!!"); 
                flag = false;
             }
            else
                errorProvider1.SetError(textBox1, "");

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "ERROR!!");
                flag = false;
            }
            else
                errorProvider2.SetError(textBox2, "");

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider3.SetError(textBox4, "ERROR!!");
                flag = false;
            }
            else
                errorProvider3.SetError(textBox4, "");

            if (string.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider4.SetError(textBox5, "ERROR!!");
                flag = false;
            }
            else
                errorProvider4.SetError(textBox5, "");

            if (textBox5.Text != textBox3.Text)
            {
                errorProvider5.SetError(textBox3, "ERROR!!");
                flag = false;
            }
            else
                errorProvider5.SetError(textBox3, "");

            return flag;
        }
    }
}
