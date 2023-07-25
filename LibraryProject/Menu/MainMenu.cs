using LibraryProject.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Menu
{
    internal class MainMenu
    {
        public static void Menu(bool move)
        {
            while (move)
            {
                Console.WriteLine("1.Add new book");
                Console.WriteLine("2.Show all book in the libarary");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete book");
                Console.WriteLine("5.Other Fuction");
                Console.WriteLine("6.Exit");
                try
                {
                    byte action = Convert.ToByte(Console.ReadLine());
                    Console.Clear();
                    switch (action)
                    {
                        case 1:
                            CreatBook.Creat(true);
                            break;
                        case 2:
                            ShowAllBook.Show();
                            break;
                        case 3:
                            UpDateBook.UpDate();
                            break;
                        case 4:
                            var delete = DeleteBook.DeleteAsync();
                            break;
                        case 5:
                            SecondMenu.MenuSecond();
                            break;
                        case 6:
                            move = false;
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
}
