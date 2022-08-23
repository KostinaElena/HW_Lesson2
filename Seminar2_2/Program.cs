int firstNumber = int.Parse(Console.ReadLine());

int secondNumber = int.Parse(Console.ReadLine());

if (secondNumber%firstNumber==0)
{
    Console.WriteLine($"{firstNumber} {secondNumber} кратно");
}
else 
{
    Console.WriteLine($"{firstNumber} {secondNumber} {secondNumber%firstNumber} не кратно");
}

