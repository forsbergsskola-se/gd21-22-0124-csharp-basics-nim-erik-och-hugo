string matches = "||||||||||||||||||||||||";
string removedMatches;
string inputNumber;
int chosenNumber;
int count = 24;

Console.WriteLine("Welcome to Nim!");
Console.WriteLine("||||||||||||||||||||||||"+count);

ThreadStart:
if(count==0){Console.WriteLine("You win!");} 
if(count<0){Console.WriteLine("you lose");}
    
    
    Console.WriteLine("How many matches do you want to draw? (1,2,3)");
    inputNumber = Console.ReadLine();
    chosenNumber = int.Parse(inputNumber);
    bool ChosenNumber1 = chosenNumber < 2 && chosenNumber > 0;
    bool ChosenNumber2 = chosenNumber < 3 && chosenNumber > 1;
    bool ChosenNumber3 = chosenNumber < 4 && chosenNumber > 2;

    
    if (ChosenNumber1)
    {
        count=(count - 1);
        removedMatches = matches.Remove(0, 1);
        Console.WriteLine(removedMatches+count);
        matches = removedMatches;
        Console.WriteLine("You have removed " + chosenNumber + " match");
        goto ThreadStart;

    }
    else
    {
        if (ChosenNumber2)
        {
            count=(count - 2);
            removedMatches = matches.Remove(0, 2);
            Console.WriteLine(removedMatches+count);
            matches = removedMatches;
            Console.WriteLine("You have removed " + chosenNumber + " matches");
            goto ThreadStart;

        }

        if (ChosenNumber3)
        {
            count=(count - 3);
            removedMatches = matches.Remove(0, 3);
            Console.WriteLine(removedMatches+count);
            matches = removedMatches;
            Console.WriteLine("You have removed " + chosenNumber + " matches");
            goto ThreadStart;
            
        }
    }