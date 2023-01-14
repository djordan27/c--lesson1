/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */


internal class Programm
{
    private static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        if(a > b && a > c) {
            Console.WriteLine($"{a}, {b}, {c} -> {a}");
        } else if(a < b && b > c) {
            Console.WriteLine($"{a}, {b}, {c} -> {b}");
        } else if(a < c && b < c) {
            Console.WriteLine($"{a}, {b}, {c} -> {c}");
        } else {
            Console.WriteLine("Попробуйте еще раз");
        }
    }
}