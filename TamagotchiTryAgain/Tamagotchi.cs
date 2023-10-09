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

}