int a = 6;
int b = 11;

Console.WriteLine($"{a} - {b}");

(a, b) = (b, a);

Console.WriteLine($"{a} - {b}");