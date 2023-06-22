Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 1;
int square;

while (counter <= number)
{
    square = counter * counter * counter;
    Console.Write("{0} ", square);
    counter++;
}
