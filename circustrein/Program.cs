namespace circustrein
{
    class Program
    {
        private static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("do you want to add a animal or see what is in the train?");
                Console.WriteLine("Z: add animal   X: see train");
                System.ConsoleKeyInfo pressedkey = Console.ReadKey();
                System.ConsoleKey choice = pressedkey.Key;

                switch (choice)
                {
                    case ConsoleKey.NumPad1:

                            break;
                    case ConsoleKey.NumPad2:

                        break;
                }
            }
        }
    }
}