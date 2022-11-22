Console.Clear();
Console.Write("Введите 1-ое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите 2-ое число: ");
int number_2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите 3-eе число: ");
int number_3 = Convert.ToInt32(Console.ReadLine()); 
int [] array = {number_1, number_2, number_3};
 Console.WriteLine("Максимальное число = " + array.Max());

