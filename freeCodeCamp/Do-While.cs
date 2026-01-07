// Hero starting health
int hero = 10;

// Monster starting health
int monster = 10;

// Create a Random object to simulate dice rolls
Random dice = new Random();

// Do-while so the battle loop runs at least once and continues
// Do the following while both hero and monster have health > 0
do
{
    // Hero attacks first so monster health subtracts first. dice rolls between 1 and 10.
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health!");

    // Monster health needs to be alive to continue the loop. If 0 or less, skip monster attack.
    if (monster <= 0) continue;

    // Monster's counterattack with same starting health value.
    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// While condition health remains for both characters.
} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

/* PS C:\Users\Owner\Csharp-Microsoft\freeCodeCamp\do-while> dotnet run
Monster was damaged and lost 5 health and now has 5 health.
Hero was damaged and lost 10 health and now has 0 health.
Monster wins!
PS C:\Users\Owner\Csharp-Microsoft\freeCodeCamp\do-while> dotnet run
Monster was damaged and lost 3 health and now has 7 health.
Hero was damaged and lost 9 health and now has 1 health.
Monster was damaged and lost 3 health and now has 4 health.
Hero was damaged and lost 8 health and now has -7 health.
Monster wins!
PS C:\Users\Owner\Csharp-Microsoft\freeCodeCamp\do-while> dotnet run
Monster was damaged and lost 4 health and now has 6 health.
Hero was damaged and lost 2 health and now has 8 health.
Monster was damaged and lost 9 health and now has -3 health.
Hero wins!
PS C:\Users\Owner\Csharp-Microsoft\freeCodeCamp\do-while> */
