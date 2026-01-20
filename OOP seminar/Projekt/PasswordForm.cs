using Projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekt
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
            this.Text = "Change password";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
            {
                activeUser.Password = textBox1.Text;
                string path = Path.Combine(Constants.EmailsFolderPath, activeUser.Mail);
                string newPersonalData = activeUser.FirstName + ";" + activeUser.LastName + ";" + activeUser.DateOfBirth + ";" + activeUser.Gender + ";" + activeUser.Mail + ";" + activeUser.Password;
                File.WriteAllText(Path.Combine(path, "PersonalData.txt"), newPersonalData);
                MessageBox.Show("Password changed!");
                this.Close();
            }
        }
        private bool check()
        {
            bool flag = true;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "ERROR!!");
                flag = false;
            }
            else
                errorProvider1.SetError(textBox1, "");

            if (textBox1.Text != textBox2.Text)
            {
                errorProvider2.SetError(textBox2, "ERROR!!");
                flag = false;
            }
            else
                errorProvider2.SetError(textBox2, "");

            return flag;
        }
    }
}