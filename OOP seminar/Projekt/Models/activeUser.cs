using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    internal static class activeUser
    {
        public static string Mail { get; set; } = "";
        public static string Password { get; set; } = "";
        public static string FirstName { get; set; } = "";
        public static string LastName { get; set; } = "";
        public static DateTime DateOfBirth { get; set; } = DateTime.MinValue;
        public static string Gender { get; set; } = "";
        
    }
}
