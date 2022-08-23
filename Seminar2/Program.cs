Random random = new();

random.Next(100,1000);

int a = random.Next(100,1000);

string b = a.ToString();

Console.WriteLine($"{a} {b[0]}{b[2]}");

