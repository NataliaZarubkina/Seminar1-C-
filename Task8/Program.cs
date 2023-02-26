Console.Write("Введите число больше нуля: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");

if (userNumber1 < 1)
    Console.WriteLine("Неверное число");
else
{
    int counter = 1;
    int result = 0;
    while (counter < userNumber1)
    {
        result = counter % 2;
        if (result == 0)
        {
            Console.Write($"{counter}, ");
            counter = counter + 1;
        }
        else counter = counter + 1;
    }
}
