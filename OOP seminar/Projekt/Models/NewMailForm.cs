using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.Models
{
    public partial class NewMailForm : Form
    {
        bool bttnclose = false;
        public NewMailForm()
        {
            InitializeComponent();
            this.Name = "New Mail";
            loadUsers();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (UserList.SelectedIndex >= 0 && !string.IsNullOrEmpty(MailBody.Text))
            {
                if (string.IsNullOrEmpty(MailSubject.Text))
                    MailSubject.Text = "(No subject)";
                string path1 = Path.Combine(Constants.EmailsFolderPath, UserList.Text, "Recieved");
                string path2 = Path.Combine(Constants.EmailsFolderPath, activeUser.Mail, "Sent");
                string newMail1 = activeUser.Mail + ";" + UserList.Text + ";" + MailSubject.Text + ";" + MailBody.Text + ";" + "ur" + ";" + DateTime.Now.ToString();
                string newMail2 = activeUser.Mail + ";" + UserList.Text + ";" + MailSubject.Text + ";" + MailBody.Text + ";" + "r" + ";" + DateTime.Now.ToString();
                bttnclose = true;
                string name = $"{Guid.NewGuid().ToString()}.txt";
                File.WriteAllText(Path.Combine(path1, name), newMail1);
                File.WriteAllText(Path.Combine(path2, name), newMail2);
                this.Close();
            }
            else if (UserList.SelectedIndex < 0 && string.IsNullOrEmpty(MailBody.Text))
            {
                errorProvider1.SetError(UserList, "Please select an item!");
                errorProvider2.SetError(MailBody, "Mail can't be empty");
            }
            else if (UserList.SelectedIndex < 0 && !string.IsNullOrEmpty(MailBody.Text))
            {
                errorProvider1.SetError(UserList, "Please select an item!!");
                errorProvider2.SetError(MailBody, "");
            }
            else
            {
                errorProvider2.SetError(MailBody, "Mail can't be empty");
                errorProvider1.SetError(UserList, "");
            }


        }
        public void loadUsers()
        {
            foreach (string dir in Directory.GetDirectories(Constants.EmailsFolderPath))
            {
                string DirectoryName = Path.GetFileName(dir);
                UserList.Items.Add(DirectoryName);
            }

        }
        private void Cancel_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        private void NewMailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!bttnclose)
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }
    }
}
