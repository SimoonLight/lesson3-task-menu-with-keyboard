// See https://aka.ms/new-console-template for more information

string[] menus = new string[5];
menus[0] = "New Game";
menus[1] = "Contunie";
menus[2] = "Settings";
menus[3] = "About";
menus[4] = "Exit";

int index = 0;

void start_menu()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("\n\n\n\t\t\tMenu\t\t\t\n\n\n");
        Console.Write(menus[0]);
        if (index == 0)
        {
            Console.Write(" <--- ");
        }
        Console.WriteLine();
        Console.Write(menus[1]);
        if (index == 1)
        {
            Console.Write(" <--- ");
        }
        Console.WriteLine();
        Console.Write(menus[2]);
        if (index == 2)
        {
            Console.Write(" <--- ");
        }
        Console.WriteLine();
        Console.Write(menus[3]);
        if (index == 3)
        {
            Console.Write(" <--- ");
        }
        Console.WriteLine();
        Console.Write(menus[4]);
        if (index == 4)
        {
            Console.Write(" <--- ");
        }
        Console.WriteLine();


        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.UpArrow)
        {
            if (index != 0)
            {
                index -= 1;
            }
        }
        else if (keyInfo.Key == ConsoleKey.DownArrow)
        {
            if (index != 4)
            {
                index += 1;
            }
        }
    }
}


start_menu();