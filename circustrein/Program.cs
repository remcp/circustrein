namespace circustrein
{
    public class Program
    {
        
        private static void Main(string[] args)
        {
            Program program = new Program();
            Train train = new Train();
            string animallist = "";
            while(true)
            {
                Console.WriteLine("do you want to add a animal or see what is in the train?");
                Console.WriteLine("1: add animal   2: see train");
                System.ConsoleKeyInfo pressedkey = Console.ReadKey();
                System.ConsoleKey choice = pressedkey.Key;
                program.cleanscreen();

                switch (choice)
                {
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("animal name?");
                        string name = Console.ReadLine();
                        program.cleanscreen();
                        Console.WriteLine("1: small animal  2: medium animal   3: big animal");
                        pressedkey = Console.ReadKey();
                        choice = pressedkey.Key;
                        program.cleanscreen();
                        Size.size size = new();
                        switch (choice)
                        {
                            case ConsoleKey.NumPad1:
                                size = Size.size.small;
                                break;

                            case ConsoleKey.NumPad2:
                                size = Size.size.medium;
                                break;

                            case ConsoleKey.NumPad3:
                                    size = Size.size.big;
                                break;
                        }
                        Console.WriteLine("is the animal a carnivore? 1: yes  2: no");
                        pressedkey = Console.ReadKey();
                        choice = pressedkey.Key;
                        program.cleanscreen();
                        bool carnivore = false;
                        switch (choice)
                        {
                            case ConsoleKey.NumPad1:
                                carnivore=true;
                                break;

                            case ConsoleKey.NumPad2:
                                carnivore = false;
                                break;
                        }

                        Animal animal = new Animal(name, size,carnivore);
                        train.addanimal(animal);
                            break;
                    case ConsoleKey.NumPad2:
                        foreach(Wagon wagon in train.WagonList)
                        {
                            animallist += wagon.ToString() + "\n";
                        }
                        Console.WriteLine(animallist);
                        Console.ReadLine();
                        program.cleanscreen();
                        break;
                }
            }
        }

        public void cleanscreen()
        {
            Console.SetCursorPosition(0, 0);
            int x = 0;
            int y = 0;

            for (y = 0; y < 15; y++)
            {
                for (x = 0; x < 70; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                }
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}