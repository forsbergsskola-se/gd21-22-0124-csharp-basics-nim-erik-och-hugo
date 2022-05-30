Console.WriteLine("What's your age?");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);

bool isChild = age <= 12 && age >= 0;
bool isTeenager= age <= 19 && age >= 13;
bool isAdult= age > 20;

if (isChild)
{
    Console.WriteLine("You're but a mere Child");
}
else
{
    if (isTeenager)
    {
        Console.WriteLine("You're a growing Teenager");
    }
    if (isAdult)
    {
        Console.WriteLine("You're an Adult");
    }
}

Console.WriteLine("Please give me an integer");
string numberInput = Console.ReadLine();
int number = int.Parse(numberInput);