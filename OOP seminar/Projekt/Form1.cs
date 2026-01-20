using Projekt.Models;

namespace Projekt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = "Login";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {

            if (Directory.Exists(Path.Combine(Constants.EmailsFolderPath, UserTXT.Text)))
            {
                string UserPassword = PasswordTXT.Text;
                List<string> lines = File.ReadAllLines(Path.Combine(Constants.EmailsFolderPath, UserTXT.Text, "PersonalData.txt")).ToList();
                bool correctPassword = false;
                foreach (string line in lines)
                {
                    string[] Data = line.Split(';');
                    if (Data[5] == UserPassword)
                    {
                        setActiveUser(Data);
                        correctPassword = true;
                    }
                }
                if (!correctPassword)
                    MessageBox.Show("Password incorrect");
            }
            else
                MessageBox.Show("User doesnt exist");

        }

        private void NewUser_button_Click(object sender, EventArgs e)
        {
            Registration newUser = new Registration();
            this.Hide();
            newUser.Show();
        }
        public void setActiveUser(string[] Data)
        {
            activeUser.FirstName = Data[0];
            activeUser.LastName = Data[1];
            activeUser.DateOfBirth = DateTime.Parse(Data[2]);
            activeUser.Gender = Data[3];
            activeUser.Mail = Data[4];
            activeUser.Password = Data[5];
            Mail login = new Mail();
            login.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
