// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.   5=5^3 
try
{
    Console.WriteLine("Введите число:");
    int N = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i <= N; i++)
    Console.WriteLine(i * i * i);
}
catch
{
    Console.WriteLine("Введите именно цифру!");
}