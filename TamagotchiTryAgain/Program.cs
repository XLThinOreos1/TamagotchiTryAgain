Console.WriteLine("Welcome to Tamagotchi game");
Tamagotchi Tama = new();

Console.WriteLine("What is your new tamagotchis name?");
Console.Write("Name: ");
Tama.name = Console.ReadLine();
Console.Clear();

List<string> options = new List<string>
        { "1. Feed", "2. Teach a new word", $"3. Talk to {Tama.name}", "4. Staring contest"};

while (Tama.GetAlive() == true)
{
    Console.Clear();
    Tama.PrintStats();

    options.ForEach(Console.WriteLine);

    string PlayerChoice = Console.ReadLine();

    if (PlayerChoice == "1")
    {
        Tama.Feed();
    }
    else if (PlayerChoice == "2")
    {
        Console.Clear();
        Console.WriteLine("What unique word would you like to add to the vocabulary of this beautiful creature?");
        string word = Console.ReadLine();
        Tama.Teach(word);
    }
    else if (PlayerChoice == "3")
    {
        Tama.Hi();
    }
    else if (PlayerChoice == "4")
    {
        Tama.StaringContest();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid answer. Doing nothing");
    }
    Task.Delay(2000).Wait();
    Tama.Tick();
}

Ending.BadEnding(Tama);