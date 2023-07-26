using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryProject.Users
{
    internal class AddNewUser
    {
        public static async Task AddUserAsync()
        {
            try
            {
                var user = new UserModel();
                Console.Write("Enter name:");
                user.UserName = Console.ReadLine();
                Console.Write("Create your Password:");
                user.UserPassword = Console.ReadLine();
                Console.Write("Enter Age:");
                user.Age= Convert.ToByte(Console.ReadLine());
                user.DateRegistration = DateOnly.Parse(DateTime.Now.ToString());
            wrongEmail:
                Console.Write("Enter Email:");
                string? currentEmail = Console.ReadLine();
                string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
                if (Regex.IsMatch(currentEmail, pattern, RegexOptions.IgnoreCase))
                    user.UserEmail = currentEmail;
                else
                {
                    Console.WriteLine("Wrong Email!!!\nTry again.. ");
                    goto wrongEmail;
                }
            }
        }
    }
}
