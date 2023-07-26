using LibraryProject.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Menu
{
    internal class FirstMenu
    {
        public static void Menu(bool move)
        {
            while (move)
            {
                Console.WriteLine("1.Create user");
                Console.WriteLine("2.Join in");
                Console.WriteLine("3.Exit");
                try
                {
                    byte action = Convert.ToByte(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            break;
                        case 2:
                            CheckUser.Check();
                            break;
                        case 3:
                            return;
                        default:
                            Console.WriteLine("Not such option");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
