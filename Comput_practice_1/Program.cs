// Variant 15
Task1(); // 1 -> 1
Task1(); // 8 -> 10
Task1(); // 125 -> 175
Task1(); // 91201 -> 262101

Task2();
Task2();
Task2();

Task3();

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

// Task_2
void Task2()
{
    Console.WriteLine("Enter x, y, z separating by enter: ");
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double z = double.Parse(Console.ReadLine());

    double a = (x * y) / z + (z / (x * y));
    double b = Math.Sin(x * y / z + 1) - Math.Cos(1 + z / (x * y)) + 0.5;
    double c = 2 - Math.Sqrt((a * a) + 5);

    double minimum = Math.Min(a, Math.Min(b, c));

    Console.WriteLine("a: " + a);
    Console.WriteLine("b: " + b);
    Console.WriteLine("c: " + c);
    Console.WriteLine("The minimum from a, b, c is: " + minimum);
}

void Task3()
{
    int[,] array2D = new int[5, 7];

    //Get user input
    Console.WriteLine("Fill the matrix: ");
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
    }


    // Printing matrix
    Console.WriteLine("Your matrix: ");
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i, j] + "\t");
        }
        Console.WriteLine();
    }

    int[] bVector = new int[5];

    // looking and counting amount of even numbers
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int counterOfEvens = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] % 2 == 0)
            {
                ++counterOfEvens;
            }
        }
        bVector[i] = counterOfEvens;
        counterOfEvens = 0;
    }

    int maxNumber = bVector[0];
    int maxIndex = 0;

    for (int i = 1; i < bVector.Length; i++)
    {
        if (bVector[i] > maxNumber)
        {
            maxNumber = bVector[i];
            maxIndex = i;
        }
    }

    Console.WriteLine($"The maximal number in vector b is: {maxNumber} and its index is: {maxIndex}");

}