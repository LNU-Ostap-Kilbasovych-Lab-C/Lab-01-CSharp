// Variant 15
Task1(); // 1 -> 1
Task1(); // 8 -> 10
Task1(); // 125 -> 175
Task1(); // 91201 -> 262101

// Task1
void Task1()
{
    Console.Write("Enter a natural number: ");
    string userInput = Console.ReadLine();
    uint userNumber = uint.Parse(userInput);
    string octalNumber = "";

    while (userNumber > 0)
    {
        uint remainder = userNumber % 8;
        octalNumber = remainder.ToString() + octalNumber;
        userNumber = userNumber / 8;
    }

    Console.WriteLine("The octal representation of " + userInput + " is " + octalNumber);
}

