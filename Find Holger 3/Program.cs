

var chars = "abcdefghijklmnopqrstuvwxyz";

Random random = new Random();
int posx = random.Next(1, 41);
int posy = random.Next(1, 41);

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Velkommen til Find Holger spillet! Se, om du kan finde: '@' iblandt alle bogstaverne.");

for (int i = 0; i < posy - 1; i++)
{
    Console.WriteLine("  ");

    for (int j = 0; j < 40; j++)
    {
        int ran = random.Next(0, chars.Length);
        Console.Write($"{chars[ran]} ");
    }
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(" " + (i + 1) + " ");
    Console.ForegroundColor = ConsoleColor.White;

}

Console.WriteLine(" ");

for (int z = 0; z < posx - 1; z++)
{
    int ran = random.Next(0, chars.Length);
    Console.Write($"{chars[ran]} ");

}

Console.Write("@ ");

for (int j = 0; j < 40 - posx; j++)
{
    int ran = random.Next(0, chars.Length);
    Console.Write($"{chars[ran]} ");
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(" " + posy);
Console.ForegroundColor = ConsoleColor.White;

for (int k = 0; k < 40 - posy; k++)
{
    Console.WriteLine("  ");

    for (int l = 0; l < 40; l++)
    {
        int ran = random.Next(0, chars.Length);
        Console.Write($"{chars[ran]} ");
    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(" " + (k + posy + 1) + " ");
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine("\n\nHvor er Holger?");

Console.WriteLine("Angiv Holgers position på X-aksen.");
int gæty = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Angiv Holgers position på Y-aksen.");
int gætx = Convert.ToInt32(Console.ReadLine());

if (gætx != posy && gæty != posx)
{
    Console.WriteLine("Forkert - du fandt mig ikke :(");
}

else
{
    Console.WriteLine("Wuuuhuuuuuuu, du fandt mig! :D");
}