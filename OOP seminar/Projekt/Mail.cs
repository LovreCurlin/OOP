using Projekt.Models;
using System.IO;
using System.Xml.Linq;

namespace Projekt
{

    public partial class Mail : Form
    {
        private List<MailModel> RecievedMails = new List<MailModel>();
        public bool AllSelected = false;
        public string currentDirectory = "Recieved";
        public Mail()
        {
            InitializeComponent();
            CreateMailList();
            this.Text = $"User ({activeUser.Mail})";

            RefreshListView();
        }
        private void CreateMailList()
        {
            MailList.HideSelection = false;
            MailList.View = View.Details;
            MailList.FullRowSelect = true;
            MailList.Columns.Add("from", 300, HorizontalAlignment.Left);
            MailList.Columns.Add("to", 300, HorizontalAlignment.Left);
            MailList.Columns.Add("subject", 300, HorizontalAlignment.Left);
            MailList.Columns.Add("date", 300, HorizontalAlignment.Left);
            MailList.Columns[0].Width = 300;
            MailList.Columns[1].Width = 0;
            loadMailsfile("Recieved");
            RefreshListView();
        }
        private void newMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMailForm form = new NewMailForm();
            form.ShowDialog();
        }
        private void deliverdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailTextBox.Clear();
            MailList.Columns[0].Width = 300;
            MailList.Columns[1].Width = 0;
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Hide();
            MailList.Height = 900;

            RecievedMails.Clear();
            loadMailsfile("Recieved");

            RefreshListView();
        }

        private void sentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentDirectory = "sent";
            MailList.Columns[0].Width = 0;
            MailList.Columns[1].Width = 300;
            MailList.Height = 992;
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            MailTextBox.Clear();
            RecievedMails.Clear();
            loadMailsfile("Sent");
            RefreshListView();
        }

        private void deletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentDirectory = "Deleted";
            MailList.Columns[0].Width = 300;
            MailList.Columns[1].Width = 0;
            MailList.Height = 900;
            MailTextBox.Clear();
            RecievedMails.Clear();
            loadMailsfile("Deleted");
            button1.Show();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Show();
            RefreshListView();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            this.Close();
            back.Show();
        }
        void loadMailsfile(string directory)
        {
            string path = Path.Combine(Constants.EmailsFolderPath, activeUser.Mail, directory);

            List<MailModel> RecievedMailsTemp = new List<MailModel>();

            foreach (string file in Directory.GetFiles(path))
            {
                string line = File.ReadAllText(file);
                string fileName = Path.GetFileName(file);
                string[] parts = line.Split(';');

                RecievedMailsTemp.Add(new MailModel(fileName, parts[0], parts[1], parts[2], parts[3], parts[4], DateTime.Parse(parts[5])));

            }
            RecievedMails = RecievedMailsTemp.OrderByDescending(r => r.DateTime).ToList();
        }
        private void RefreshListView()
        {
            MailList.Items.Clear();

            foreach (var mail in RecievedMails)
            {
                ListViewItem item = new ListViewItem(mail.Sender);
                item.SubItems.Add(mail.Reciever);
                item.SubItems.Add(mail.Subject);
                item.SubItems.Add(mail.DateTime.ToString());

                MailList.Items.Add(item);
                if (!mail.IsRead)
                    item.Font = new Font(MailList.Font, FontStyle.Bold);
                else
                    item.Font = new Font(MailList.Font, FontStyle.Regular);
            }
        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MailList.SelectedItems.Count == 0)
                return;

            int index = MailList.SelectedItems[0].Index;
            var selectedMail = RecievedMails[index];

            MailTextBox.Text = selectedMail.Body;

            if (!selectedMail.IsRead)
                SaveMail(index, "r");

            selectedMail.IsRead = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MailTextBox.Clear();
            foreach (ListViewItem item in MailList.Items)
            {
                item.Selected = !AllSelected;
            }
            AllSelected = !AllSelected;
            if (AllSelected)
                button1.Text = "Deselect all";
            else
                button1.Text = "Select all";

        }
        private void button2_Click(object sender, EventArgs e)
        {

            var selected = MailList.SelectedItems.Cast<ListViewItem>().OrderByDescending(i => i.Index).ToList();

            foreach (var item in selected)
            {
                int index = item.Index;
                var mail = RecievedMails[index];

                string path = Path.Combine(Constants.EmailsFolderPath, activeUser.Mail, "Recieved", mail.FileName);
                string destPath = Path.Combine(Constants.EmailsFolderPath, activeUser.Mail, "Deleted", mail.FileName);

                if (File.Exists(path))
                    File.Move(path, destPath);

                RecievedMails.RemoveAt(index);
            }

            RefreshListView();
            AllSelected = false;
            MailTextBox.Clear();
            button1.Text = "Select all";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MailList.SelectedItems)
            {
                int index = item.Index;
                RecievedMails[index].IsRead = false;
                SaveMail(index, "ur");
            }
            button1.Text = "Select all";
            AllSelected = false;
            MailTextBox.Clear();
            RefreshListView();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MailList.SelectedItems)
            {
                int index = item.Index;
                RecievedMails[index].IsRead = true;
                SaveMail(index, "r");
            }
            button1.Text = "Select all";
            AllSelected = false;
            MailTextBox.Clear();
            RefreshListView();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var selected = MailList.SelectedItems.Cast<ListViewItem>().OrderByDescending(i => i.Index).ToList();
            foreach (var item in selected)
            {
                int index = item.Index;
                string path = Path.Combine(Constants.EmailsFolderPath, activeUser.Mail, "Recieved", RecievedMails[index].FileName);

                string destPath = Path.Combine(Constants.EmailsFolderPath, activeUser.Mail, "Deleted", RecievedMails[index].FileName);
                File.Move(destPath, path);
                MailTextBox.Clear();
                RecievedMails.RemoveAt(index);
            }
            RefreshListView();
        }

        private void PersonalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First name: " + activeUser.FirstName + Environment.NewLine +
                            "Last name: " + activeUser.LastName + Environment.NewLine +
                            "Date of birt: " + activeUser.DateOfBirth + Environment.NewLine +
                            "Gender: " + activeUser.Gender + Environment.NewLine +
                            "Email: " + activeUser.Mail + Environment.NewLine
                           );
        }

        private void deleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delite your account?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string path = Path.Combine(Constants.EmailsFolderPath, activeUser.Mail);
                deleteMails("Sent");
                deleteMails("Recieved");
                deleteMails("Deleted");
                File.Delete(Path.Combine(path, "PersonalData.txt"));
                Directory.Delete(path);
                Login form = new Login();
                this.Close();
                form.Show();
            }

        }
        private void deleteMails(string directory)
        {
            string path = Path.Combine(Constants.EmailsFolderPath, activeUser.Mail, directory);

            foreach (string file in Directory.GetFiles(path))
            {
                File.Delete(file);
            }
            Directory.Delete(path);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordForm form = new PasswordForm();
            form.ShowDialog();
        }
        public void SaveMail(int index, string read)
        {
            var selectedMail = RecievedMails[index];
            string saveMail = selectedMail.Sender + ";" + selectedMail.Reciever + ";" + selectedMail.Subject + ";" + selectedMail.Body + ";" + read + ";" + selectedMail.DateTime;
            string path = Path.Combine(Constants.EmailsFolderPath, activeUser.Mail, currentDirectory, selectedMail.FileName);
            File.WriteAllText(path, saveMail);

        }

        

    }
}


