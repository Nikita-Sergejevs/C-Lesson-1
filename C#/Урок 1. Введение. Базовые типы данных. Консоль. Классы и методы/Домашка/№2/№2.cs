double m;
double h;

Console.Write("Здраствуйте, введите свой вес к килограммах: ");
string weight = Console.ReadLine();
m = Convert.ToDouble(weight);

Console.Write("Введите свой рост в метрах: ");
string height = Console.ReadLine();
h = Convert.ToDouble(weight);

double i=m/(h*h);

Console.Write($"Индекс массы тела: {i}");