using LibraryProject.DDManager;
using LibraryProject.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Users
{
    internal class CheckUser
    {
        public static void Check()
        {
            Console.Write("Enter Login:");
            string? userLoging= Console.ReadLine();
            Console.Write("Enter Password:");
            string? userPassword = Console.ReadLine();
            var allUSers = (from user in GetAllUsers.GetUser()
                           where user.UserName.Equals(userLoging)
                           where user.UserPassword.Equals(userPassword)
                           select user).ToList();
            if(allUSers!=null)
            MainMenu.Menu();
            else
            {
                Console.WriteLine("This user not found!\nTry again..");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
