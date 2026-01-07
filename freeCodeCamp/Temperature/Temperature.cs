//Convert fahrenheit to celsius to Kelvin calculator
int fahrenheit = 55;
Console.Write("When the temperature is " + fahrenheit + " Fahrenheit,");
Console.ReadLine();
//Allow for calculator to read decimals
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
//Print out only to two decimal places
celsius = Math.Round(celsius, 2);
Console.WriteLine("The temperature is " + celsius + " Celsius.");
decimal Kelvin = ((fahrenheit - 32m) * (5m / 9m)) + 273m;
Kelvin = Math.Round(Kelvin, 2);
Console.WriteLine("The temperature is " + Kelvin + " Kelvin");
