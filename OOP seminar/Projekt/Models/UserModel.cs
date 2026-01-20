using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projekt
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FolderPath => @$"{Constants.EmailsFolderPath}\{Email}\";

        public User(string name,string surname, DateTime dateofbirth,string gender,string email, string password)
        {
            FirstName = name;
            LastName = surname;
            DateOfBirth = dateofbirth;
            Gender = gender;
            Email = email;
            Password = password;
        }

        public void CreateUserFolder()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
                Directory.CreateDirectory(Path.Combine(FolderPath, "Recieved"));
                Directory.CreateDirectory(Path.Combine(FolderPath, "Sent"));
                Directory.CreateDirectory(Path.Combine(FolderPath, "Deleted"));
            }
        }

    }
}
