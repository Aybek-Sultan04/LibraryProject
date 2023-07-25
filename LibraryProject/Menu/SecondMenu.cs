using LibraryProject.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Menu
{
    internal class SecondMenu
    {
        public static void MenuSecond()
        {
            Console.WriteLine("1.The most expensive book in the library");
            Console.WriteLine("2.The cheapest book in the library");
            Console.WriteLine("3.The thickest book in the library");
            Console.WriteLine("5.Back");
            try
            {
                byte action = Convert.ToByte(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        Option.Expensive();
                        break;
                    case 2:
                        Option.Cheap();
                        break;
                    case 3:
                        Option.Fat();
                        break;
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
