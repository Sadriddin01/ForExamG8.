using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForExamG8.Services
{
    public partial class Services
    {
        private List<Foods> foods=new List<Foods>();
        private List<About> infos=new List<About>();
        public static void FoodMenu(Services CenterServices)
        {
            bool exit=false;
            var index = 0;
            List<string> order3 = new List<string>
            {
                "Add Foods",
                "List of Foods",
                "Clear List of Foods",
                "Back to Menu"
            };
            while(!exit)
            {
                Console.Clear();
                for (int i = 0; i < order3.Count; i++)
                {
                    if(i==index)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.WriteLine(order3[i]);
                    Console.ResetColor();
                }
                var key=Console.ReadKey(true);
                if(key.Key==ConsoleKey.DownArrow)
                {
                    index=(index+1)%order3.Count;
                }
                else if(key.Key==ConsoleKey.UpArrow)
                {
                    index=(index-1+order3.Count)%order3.Count;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    switch(index)
                    {
                        case 0:
                            CenterServices.AddFood();
                            break;
                        case 1:
                            CenterServices.GetFoods(); 
                            break;
                        case 2:
                            CenterServices.ClearFFile();
                            break;
                        case 3:
                            exit = true;
                            break;
                    }
                    Console.ReadKey();
                }
            }
        }
        public static void AboutMenu(Services CenterServices)
        {
            bool exit = false;
            int index = 0;
            List<string> order = new List<string>
            {
                "Add Information",
                "Get Information",
                "Clear information",
                "Update Information",
                "Back"
            };
            while(!exit)
            {
                Console.Clear();
                for(int i = 0; i < order.Count; i++)
                {
                    if(i==index)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(order[i]);
                    Console.ResetColor();
                }
                var key = Console.ReadKey(true);
                if(key.Key== ConsoleKey.DownArrow)
                {
                    index = (index + 1) % order.Count;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    index = (index - 1 + order.Count) % order.Count;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    switch (index)
                    {
                        case 0:
                            CenterServices.AddAbout();
                            break;
                        case 1:
                            CenterServices.GetAbout();
                            break;
                        case 2:
                            CenterServices.ClearIFile();
                            break;
                        case 3:
                            CenterServices.UpdateAbout();
                            break;
                        case 4:
                            exit = true;
                            break;
                    }
                    Console.ReadKey();
                }
            }

        }

    }
}
