//HelloWorld();

//static void HelloWorld()
//{
//    Console.WriteLine("Hello, World!");
//}

//Console.WriteLine("Enter your name:");
//string userName = Console.ReadLine();

//GreetUser(userName);

//static void GreetUser(string someName)
//{
//    Console.WriteLine($"Hello, {someName}");
//}

//--------------------------------------------------

//Console.WriteLine("Enter your comment:");
//string userInput = Console.ReadLine();

//CountSpaces(userInput);

//static void CountSpaces(string someString)
//{
//    someString = someString.Trim();
//    int wordCounter = 1;

//    foreach (char symbol in someString)
//    {
//        if (char.IsWhiteSpace(symbol))
//        {
//            wordCounter++;
//        }
//    }

//    string word = "word";
//    if (wordCounter > 1)
//    {
//        word = "words";
//    }

//    Console.WriteLine($"Your comment contains {wordCounter} {word}.");
//}

//------------------------------------------------------------------

//Console.WriteLine("Enter the operation (+ or - or * or /):");
//char userOperator = Char.Parse(Console.ReadLine());
//Console.WriteLine("Enter a:");
//int firstNum = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Enter b:");
//int secondNum = Int32.Parse(Console.ReadLine());
//switch (userOperator)
//{
//    case '+':
//        Add(firstNum, secondNum);
//        break;
//    case '-':
//        Subtract(firstNum, secondNum);
//        break;

//    case'*':
//        Multiply
//        (firstNum,secondNum);
//        break;
//    case'/':
//        Divide(firstNum,secondNum);
//        break;
//    default:
//        Console.WriteLine("invalid operator");
//        break;
//}
////functions
//static void Add(int a, int b)
//{
//    Console.WriteLine($"{a} + {b} = {a + b}");
//}
//static void Subtract(int a, int b)
//{
//    Console.WriteLine($"{a} - {b} = {a - b}");
//}
//static void Multiply(int a, int b)
//{
//    Console.WriteLine($"{a} * {b} = {a * b}");
//}
//static void Divide(int a, int b )
//{
//    Console.WriteLine($"{a} / {b} = {a / b}");
//}
//----------------------------------------------------

Console.WriteLine("How many steps have you walked today?");
int usersSteps = Int32.Parse(Console.ReadLine());

string result = HealthMonitor(usersSteps);

Console.WriteLine(result);

static string HealthMonitor(int steps)
{
    if (steps < 4000)
    {
    return "You need to move more.";
    }
    else if (steps >= 4000 && steps < 8000)
    {
     return "Health goal achieved,";
    }
    else
    {
     return  "Well done!";
    }
}