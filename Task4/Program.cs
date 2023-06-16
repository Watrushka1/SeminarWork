    Console.WriteLine("Введите число : ");
      int number = Convert.ToInt32(Console.ReadLine());
          int numberStart=2;
         
while (numberStart<=number)
{  
      if (numberStart % 2 == 0)
            {
                        Console.Write(numberStart);
                        Console.Write(" ");
            }
             numberStart=numberStart+2;   
}




   