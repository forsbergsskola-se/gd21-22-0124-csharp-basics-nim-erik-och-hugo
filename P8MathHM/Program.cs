Console.WriteLine("What is your age?");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);


bool isChild = age <= 12 && age >= 0;
Console.WriteLine("you are a child: "+ isChild);



Console.ReadLine();