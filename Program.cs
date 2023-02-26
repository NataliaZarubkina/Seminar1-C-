Console.Write("Add number: ");
string userInputStr = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInputStr);
int result = userNumber * userNumber;
Console.WriteLine($"{userNumber} -> {result}"); // выводит результат в виде двух переменных)