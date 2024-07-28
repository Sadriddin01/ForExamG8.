using ForExamG8.Services;

public static class Program
{
    public static void Main(string[] args)
    {
        bool exit=false;
        int index = 0;
        var CenterServices = new Services();
        List<string> order1 = new List<string>
        {
            "Restaurant Admin",
            "User"
        };
        
        while(!exit)
        {
            Console.Clear();
            Console.WriteLine("Are you Admin or user ?");
            for (int i = 0; i < order1.Count; i++)
            {
                if(i==index)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(order1[i]);
                Console.ResetColor();
            }
            var key= Console.ReadKey(true);
            if(key.Key==ConsoleKey.DownArrow)
            {
                index=(index+1)%order1.Count;
            }
            else if(key.Key==ConsoleKey.UpArrow)
            {
                index=(index-1+order1.Count)%order1.Count;
            }
            else if(key.Key==ConsoleKey.Enter)
            {
                switch(index)
                {
                    case 0:
                        AdminManu(CenterServices);
                            break;
                    case 1:
                        
                        break;

                }
            }
        }
    }
    static void AdminManu(Services CenterServices)
    {
        bool exit = false;
        int index = 0;
        List<string> order2 = new List<string>
        {
            "Food Menu",
            "Add Info About Restaurant",
            "Catch Order From User or Don't Catch",
            "Back"
        };
        while(!exit)
        {
            Console.Clear();
            Console.WriteLine("< Restaurant Admin >");
            for (int i = 0; i < order2.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(order2[i]);
                Console.ResetColor();
            }
            var key=Console.ReadKey(true);
            if(key.Key==ConsoleKey.DownArrow)
            {
                index=(index+1)%order2.Count;
            }
            else if(key.Key==ConsoleKey.UpArrow)
            {
                index=(index-1+order2.Count)%order2.Count;
            }
            else if(key.Key==ConsoleKey.Enter)
            {
                switch(index)
                {
                    case 0:
                        Services.FoodMenu(CenterServices);
                        break;
                    case 1:
                        Services.AboutMenu(CenterServices); 
                        break;
                }
            }
        }
    }
    static void UserMenu(Services CenterServices)
    {
        bool exit = false;
        int index = 0;
        List<string> order3 = new List<string>
        {
            "Food Menu",
            "Read About Restaurant",
            "Order Foods"
        };
        while(!exit)
        {
            Console.Clear();
            Console.WriteLine("< User >");

        }
    }
}