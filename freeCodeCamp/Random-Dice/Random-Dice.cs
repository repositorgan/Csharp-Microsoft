// Variable random assignment to class dice
Random dice = new Random();
// Three separate dice roll to assign to integer variables
int roll1 = dice.Next(1, 7); // Integer variables for class.Method(lower inclusive, upper exclusive)
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// Total of all three dice rolls
int total = roll1 + roll2 + roll3;
 // Output total dice values
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Boolean inquiry for if dice values equal each other
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) // and or
{ 
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

// Determine the outcome tier based on the total score
if (total >= 17)
{
    Console.WriteLine("You win! Play again?");
}

else if (total >= 9)
{
    Console.WriteLine("You win an extra roll!");
}

else
{
    Console.WriteLine("Please roll again.");
}
