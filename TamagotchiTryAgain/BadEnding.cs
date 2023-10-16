public class Ending
{
    public static void BadEnding(Tamagotchi Tama)
    {

        Console.Clear();
        Console.WriteLine(@$"
                 ______
           _____/      \\_____
          |  _     ___   _   ||
          | | \     |   | \  ||
          | |  |    |   |  | ||
          | |_/     |   |_/  ||
          | | \     |   |    ||
          | |  \    |   |    ||
          | |   \. _|_. | .  ||
          |                  ||
               {Tama.name}
          | Had a bad owner  ||
  *       | *   **    * **   ||*      **
   \)),/(/,/.,(//,,..,,\||(,,.,\\,.((//");
        Console.WriteLine($"\nDumbass you killed {Tama.name}");
        Console.WriteLine($"Don't kill him next time!");
        Task.Delay(5000).Wait();
    }
}