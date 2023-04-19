//Number Analyzer Lab

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("Please enter an integer between 1 and 100 inclusive.");
string userEntry;
userEntry = Console.ReadLine();
double result = double.Parse(userEntry);
double remainder = result % 2;

if (remainder > 0 && result > 60)
{
    Console.WriteLine($"{name}, {userEntry} is odd and less than 60.");
}
//Cas: It's giving me an error just on lines 13 & 23 because && cannot be applied to int and bool. But I've parset to double. Not sure what's happening.
else if (remainder = 0 && result > 60)
{
    Console.WriteLine($"{name}, {userEntry} is even and greater than 60.");
}

else if (remainder > 0 && result > 60)
{
    Console.WriteLine($"{name}, {userEntry} is odd and greater than 60.");
}

else if (remainder = 0 && result < 1 && result > 25)
{
    Console.WriteLine($"{name}, {userEntry} is even and less than 25.");
}

else if (remainder > 0 && result > 25 && result < 61)
{
    Console.WriteLine($"{name}, {userEntry} is even and between 26 and 60 inclusive.");
}

Console.ReadKey();