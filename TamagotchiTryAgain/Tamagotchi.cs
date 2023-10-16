public class Tamagotchi
{
    public string name;
    private int hunger;
    private int boredom;
    private bool isAlive = true;
    private Random generator = new Random();
    private List<string> words = new List<string>() { "Apple" };

    public void Feed()
    {
        Console.Clear();
        if (hunger == 0 || hunger == 1)
        {
            Console.WriteLine($"{name} is not hungry");
        }
        else
        {
            Console.WriteLine($"You fed {name} a banana slice");
            hunger -= 2;

            if (hunger < 0)
            {
                hunger = 0;
            }
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"{name}");
        Console.WriteLine("------------------");
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");
        Console.WriteLine($"Alive: {isAlive}\n");
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    public void Tick()
    {
        boredom++;
        hunger++;

        if (boredom > 5 || hunger > 5)
        {
            isAlive = false;
        }
    }

    private void ReduceBoredom()
    {
        boredom -= 2;

        if (boredom < 0)
        {
            boredom = 0;
        }
        Console.WriteLine("Your tamagotchi is now less bored");
    }

    public void Teach(string word)
    {
        words.Add(word);
        Console.WriteLine($"You taught {name} the word {word}");
        Console.WriteLine($"{name} is now slightly less illiterate");
        ReduceBoredom();
    }

    public void Hi()
    {
        Console.Clear();
        int RandomWord = generator.Next(words.Count);
        Console.WriteLine($"{name}: {words[RandomWord]}");

        ReduceBoredom();
    }

    public void StaringContest()
    {
        Console.Clear();
        Console.WriteLine("O _ O");
        Task.Delay(5000).Wait();
        Console.Write(".");
        Task.Delay(2000).Wait();
        Console.Write(".");
        Task.Delay(2000).Wait();
        Console.Write(".");
        Task.Delay(2000).Wait();

        Console.WriteLine("\nWell that was boring.");
    }
}