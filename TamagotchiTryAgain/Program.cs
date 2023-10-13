Console.WriteLine("Welcome to Tamagotchi game");
Tamagotchi Tama = new();

Tama.name = Console.ReadLine();

while (Tama.GetAlive() == true)
{
    Console.Clear();

}

