//Want our first value to print second
int value = 5;
bool flag = value > 0;

if (flag)
{   int secondValue = 6;
    int sum = value + secondValue;
    //first value being printed
    Console.WriteLine($"Inside the code block: {sum}");
}

Console.WriteLine($"Outside the code block: {value}");

// Inside the code block: 11
// Outside the code block: 5
