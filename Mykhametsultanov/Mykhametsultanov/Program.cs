Console.WriteLine("Введите 3 стороны треугольника");

double a = Convert.ToDouble(Console.ReadLine());

double b = Convert.ToDouble(Console.ReadLine());

double c = Convert.ToDouble(Console.ReadLine());

double p = (a + b + c) / 2;

double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

double R = (a * b * c) / (4 * s);

double S_circle = Math.PI * Math.Pow(R, 2);

Console.WriteLine(S_circle);