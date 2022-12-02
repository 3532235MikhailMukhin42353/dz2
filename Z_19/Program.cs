// 19. Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
try
{
    int[] array = { 1, 2, 3, 2, 1 };
    if (array[0] == array[4] && array[1] == array[3]) Console.WriteLine("Число палиндром");
    else Console.WriteLine("Число не палиндром");
}
catch
{
    Console.WriteLine("Введите именно цифры!")
}
