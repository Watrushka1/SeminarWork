Console.WriteLine("Введите коорлинату x1 : ");
int Xcoor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коорлинату y1 : ");
int Ycoor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коорлинату z1 : ");
int Zcoor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коорлинату x2 : ");
int Xcoor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коорлинату y2 : ");
int Ycoor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коорлинату z2 : ");
int Zcoor1 = Convert.ToInt32(Console.ReadLine());

double resultX = Math.Pow(Xcoor - Xcoor1, 2);

double resultY = Math.Pow(Ycoor - Ycoor1, 2);

double resultZ = Math.Pow(Zcoor - Zcoor1, 2);

double distance = Math.Sqrt(resultX + resultY + resultZ);
distance=Math.Round(distance, 2);

Console.Write(distance);







