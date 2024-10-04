class program
{
    static Queue<string> _queue = new Queue<string>();

    static void AddClient()
    {
        Console.Beep(1000, 250);
        Console.WriteLine("Podaj Klienta: ");
        Console.Beep(500, 125);
        string imie = Console.ReadLine();
        _queue.Enqueue(imie);
        Console.Beep(1000, 250);
        Console.WriteLine("Klient " + imie + " został dodany do kolejki !");
    }

    static void ServeClient()
    {
        Console.Beep(1000, 250);
        string imie = _queue.Dequeue();
        Console.Beep(1000, 250);
        Console.WriteLine("Obsłużonono klienta o imieniu : \"" + imie + "\"");
    }

    static void ShowClientsInQueue()
    {
        Console.Beep(1000, 250);
        Console.WriteLine("W kolejce znajdują się " + _queue.Count + " osób.");
        Console.Beep(1000, 250);
        Console.WriteLine("Są to kolejno: ");
        foreach (string client in _queue)
        {
            Console.Beep(500, 125);
            Console.WriteLine(client + " , ");
        }
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine(" ");
            Console.Beep(1000, 250);
            Console.WriteLine("Co chcesz zrobić? :\n 0. wyjdź z aplikacji \n 1. Dodać klienta \n 2. Obsłużyć klienta \n 3. Pokaż kolejkę klientów");
            int odp = Convert.ToInt32(Console.ReadLine());
            switch (odp)
            {
                case 0:
                    Console.Beep(500, 125);
                    Environment.Exit(0);
                    break;
                case 1:
                    AddClient();
                    break;
                case 2:
                    ServeClient();
                    break;
                case 3:
                    ShowClientsInQueue();
                    break;
                default:
                    Console.Beep(2000, 250);
                    Console.WriteLine("Nieprawidłowa opcja, spróbuj ponownie.");
                    break;
            }
        }
    }
}
