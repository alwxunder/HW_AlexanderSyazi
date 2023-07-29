int num = new Random (). Next(100, 1000);

int a = num / 10;
int result = a % 10;

Console.WriteLine($"{num} -> {result}");