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
            Console.WriteLine("2.Best selling book in the library");
            Console.WriteLine("3.Best selling 3 books");
            Console.WriteLine("4.Worst selling book in the library");
            Console.WriteLine("5.Back");
            try
            {
                byte action = Convert.ToByte(Console.ReadLine());
                switch(action)
                {
                    case 1:
                        break;
                        case 2:
                        break;
                        case 3:
                        break;
                        case 4:
                        break;
                        case 5:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
