namespace Game
{
    public class Game
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                DisplayMenu();
                //ConnectionDB();
                string menuChoise = Console.ReadLine();
                switch (menuChoise)
                {
                    case "1":
                        
                        break;
                    case "2":
                        Console.WriteLine("\n Work In Progress\n");
                        Console.WriteLine(" Press any key to continue...\n");
                        Console.ReadKey();
                        break;
                    case "3":
                        return;
                }
            }
        }

        static private void DisplayMenu()
        {
            Console.WriteLine("\n ╔═══════════════╗");
            Console.WriteLine(" ║ Play      : 1 ║");
            Console.WriteLine(" ╚═══════════════╝\n");
            Console.WriteLine(" ╔═══════════════╗");
            Console.WriteLine(" ║ Score     : 2 ║");
            Console.WriteLine(" ╚═══════════════╝\n");
            Console.WriteLine(" ╔═══════════════╗");
            Console.WriteLine(" ║ Quit      : 3 ║");
            Console.WriteLine(" ╚═══════════════╝\n");
            Console.Write(" ► ");
        }

    }
}