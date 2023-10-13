public class Tamagotchi
{
    public string name;
    private int hunger;
    private int boredom;
    private bool isAlive = true;
    private Random generator;
    private List<string> words = new List<string>() { "Apple" };

    public void Feed()
    {
        hunger--;
        Console.WriteLine($"You fed {name}\nThey are now less hungry");
    }

    void PrintStats()
    {
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");
        Console.WriteLine($"Status: {isAlive}");
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
        boredom--;
        Console.WriteLine("Your tamagotchi is now less bored");
    }

    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
        Console.WriteLine($"You taught {name} the word {word}");
        Console.WriteLine($"{name} is now slightly smarter");
    }

    public void Hi()
    {
        int RandomWord = generator.Next(words.Count);
        Console.WriteLine($"{words[RandomWord]}");

        ReduceBoredom();
    }
}