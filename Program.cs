// See https://aka.ms/new-console-template for more information

int choice = 0;

do
{
  Console.WriteLine("1. Play");
  Console.WriteLine("2. Quit");
  Console.WriteLine("Enter choice:");
  string choiceString = Console.ReadLine();
  choice = int.Parse(choiceString);

  if (choice == 1)
  {
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("Enter choice:");

    string calculationString = Console.ReadLine();
    int calculationChoice = int.Parse(calculationString);

    Console.WriteLine("Enter a number:");
    string number1String = Console.ReadLine();
    int number1 = int.Parse(number1String);

    Console.WriteLine("Enter another number:");
    string number2String = Console.ReadLine();
    int number2 = int.Parse(number2String);

    switch (calculationChoice)
    {
      case 1:
      Console.WriteLine($"The answer is: {number1 + number2}");
      break;

      case 2:
      Console.WriteLine($"The answer is: {number1 - number2}");
      break;

      case 3:
      Console.WriteLine($"The answer is: {number1 * number2}");
      break;

      case 4:
      Console.WriteLine($"The answer is: {number1 / number2}");
      break;
    }
  }

  else if (choice != 2)
  {
    Console.WriteLine("Invalid choice!");
  }

} while (choice != 2);

Console.WriteLine("Goodbye!");
