double x1;
double x2;
double y1;
double y2;

Console.Write("Введите x1: ");
string X1 = Console.ReadLine();
x1 = Convert.ToDouble(X1);

Console.Write("Введите x2: ");
string X2 = Console.ReadLine();
x2 = Convert.ToDouble(X2);

Console.Write("Введите y1: ");
string Y1 = Console.ReadLine();
y1 = Convert.ToDouble(Y1);

Console.Write("Введите y2: ");
string Y2 = Console.ReadLine();
y2 = Convert.ToDouble(Y2);

double z = Math.Sqrt(Math.Pow(x2 - x1,2)+Math.Pow(y2 - y1,2));

Console.Write($"Ответ: {z:F2}");