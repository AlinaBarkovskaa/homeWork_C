Console.Clear();
Console.Write("Введите 1-ое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите 2-ое число: ");
int number_2 = Convert.ToInt32(Console.ReadLine()); 
if(number_1 > number_2)
{
   
   Console.WriteLine("max = " + number_1 + " и " + "min = " + number_2);
}
else if(number_1 < number_2)
{
   
   Console.WriteLine("max = " + number_2 + " и " + "min = " + number_1);
}
else
{
   Console.WriteLine("Оба числа равны");
}