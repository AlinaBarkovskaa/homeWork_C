Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int enteredNumber = number %  2;
if( number == 0)
{
Console.WriteLine("Yes");
}
else
{
Console.WriteLine("No");
}
