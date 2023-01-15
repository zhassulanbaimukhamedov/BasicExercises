// 1. Write a program to print user name
//ReadWriteName();

static void ReadWriteName()
{
    Console.WriteLine("- What is your name? ");
    Console.Write("- ");
    string name = Console.ReadLine();
    Console.WriteLine($"- Hello {name}!");
}

// 2. Write a program to print the sum of two numbers
//SumOfTwo();

static void SumOfTwo()
{
    Console.Write("Enter any number: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter other number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Sum of two: {number1 + number2}.");
}

// 3. Write a program to print the result of dividing two numbers
static void DivOfTwo()
{
    Console.Write("Enter any number: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter other number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Division of two: {number1 / number2}.");
}

// 4. Write a program to print the result of the specified operations
static void SpecOperations()
{
    Console.WriteLine("The specified operations:");
    Console.WriteLine($"-1 + 4 * 6 = {-1 + 4 * 6}");
    Console.WriteLine($"(35 + 5) % 7 = {(35 + 5) % 7}");
    Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
    Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");
}

// 5. Write a program to swap two numbers
static void SwapTwoNumbers()
{
    Console.WriteLine("Swap two numbers.");
    Console.WriteLine("Enter first number:");
    int firstNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int secondNum = Convert.ToInt32(Console.ReadLine());
    Swap(ref firstNum, ref secondNum);
    Console.WriteLine($"First number: {firstNum}");
    Console.WriteLine($"Second number: {secondNum}");
}

static void Swap(ref int firstNum, ref int secondNum)
{
    secondNum = firstNum + secondNum;
    firstNum = secondNum - firstNum;
    secondNum = secondNum - firstNum;
}

