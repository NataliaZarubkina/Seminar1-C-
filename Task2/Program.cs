Console.Write("Add number1: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Add number2: ");
int userNumber2 = int.Parse(Console.ReadLine() ?? "");

if(userNumber1 > userNumber2)
    Console.WriteLine($"{userNumber1} > {userNumber2}");
else Console.WriteLine($"{userNumber2} > {userNumber1}");