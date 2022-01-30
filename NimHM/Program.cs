string matches = "||||||||||||||||||||||||";//scoreboard
string removedMatches;
string inputNumber;//number given by player then converted to int "chosenNumber"
int chosenNumber;
int count = 24; // to keep check of remaining matches, removes from this every time an action is completed
var randomGenerator = new Random(); //random number generator, later forced to remain within 1-4 which gives us numbers 1,2,3
var numberOfTurns = 24;
Console.WriteLine("Welcome to Nim!");

ThreadStart:
if
    (count == 0)
{
    Console.WriteLine("You lose!");

}

Console.WriteLine("How many matches do you want to remove? (1,2,3)");
    Console.WriteLine(matches + count+" Remaining matches");

    inputNumber = Console.ReadLine();
    chosenNumber = int.Parse(inputNumber);
    bool ChosenNumber1 = chosenNumber < 2 && chosenNumber > 0; // boolian values that gives player the correct action when inputting 1,2,3
    bool ChosenNumber2 = chosenNumber < 3 && chosenNumber > 1;
    bool ChosenNumber3 = chosenNumber < 4 && chosenNumber > 2;

for (int i = 0; i < 100; i++)
    

if ((i % 2) == 0)

{
    if (count > 0)
    {
        //ai script
        if (count >3)
        {
            int randomInt = randomGenerator.Next(1, 4);
            count = (count - randomInt);
            removedMatches = matches.Remove(0, randomInt);
            Console.WriteLine("ai  has removed " + randomInt + " match(es)");
            matches = removedMatches;
            
        }
        if (count>2)
        {
            
        }
        
        
    }


}
else //playerscript
{
    if (ChosenNumber1)
    {
        numberOfTurns = (numberOfTurns - 1);
        count = (count - 1);
        removedMatches = matches.Remove(0, 1);

        Console.WriteLine("You have removed " + chosenNumber + " match");
        matches = removedMatches;
        goto ThreadStart;
    }

    if (ChosenNumber2)
    {
        numberOfTurns = (numberOfTurns - 1);
        count = (count - 2);
        removedMatches = matches.Remove(0, 2);

        Console.WriteLine("You have removed " + chosenNumber + " matches");
        matches = removedMatches;
        goto ThreadStart;

    }

    if (ChosenNumber3)
    {
        numberOfTurns = (numberOfTurns - 1);
        count = (count - 3);
        removedMatches = matches.Remove(0, 3);
        matches = removedMatches;
        Console.WriteLine("You have removed " + chosenNumber + " matches");

        goto ThreadStart;

    }

}