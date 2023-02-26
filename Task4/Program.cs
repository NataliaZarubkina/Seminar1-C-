Console.Write("Add number1: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Add number2: ");
int userNumber2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Add number3: ");
int userNumber3 = int.Parse(Console.ReadLine() ?? "");

int max = userNumber1;
if (max < userNumber2)
{
    max = userNumber2;
    if (max < userNumber3)
    max = userNumber3;
}
Console.WriteLine($"max = {max}");