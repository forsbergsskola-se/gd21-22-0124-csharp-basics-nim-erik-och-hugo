Console.WriteLine("From 1 to 1000:");
int startNum = 0;

for (startNum = 1; startNum<=1000; startNum++) 
{
    Console.WriteLine(startNum);
    Console.WriteLine();
}

Console.WriteLine("From 200 to 100:");
for (startNum = 200; startNum >= 100; startNum--)
{
    Console.WriteLine(startNum);
    Console.WriteLine();
}

Console.WriteLine("From 1024 to 1:");
for (startNum = 1024; startNum >= 1; startNum = startNum/2)
{
    Console.WriteLine(startNum);
    Console.WriteLine();
}