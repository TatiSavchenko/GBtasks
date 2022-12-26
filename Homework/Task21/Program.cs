using static System.Console;


Write("Point A -> Enter x: ");
int.TryParse(ReadLine(),out int ax);

Write("Point A -> Enter y: ");
int.TryParse(ReadLine(),out int ay);

Write("Point A -> Enter z: ");
int.TryParse(ReadLine(),out int az);

Write("Point B -> Enter x: ");
int.TryParse(ReadLine(),out int bx);

Write("Point B -> Enter y: ");
int.TryParse(ReadLine(),out int by);

Write("Point B -> Enter z: ");
int.TryParse(ReadLine(),out int bz);

double length = Math.Sqrt(Math.Pow((ax-bx),2)+Math.Pow((ay-by),2)+Math.Pow((az-bz),2));
WriteLine($"{length:f2}");