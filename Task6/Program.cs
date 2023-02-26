Console.Write("Add number: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");

int result = userNumber1 % 2;
if (result==0)
    Console.WriteLine($"{userNumber1} - четное число");
else Console.WriteLine($"{userNumber1} - нечетное число");