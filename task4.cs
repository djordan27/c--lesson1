/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"{a} -> ");
if(a < 0){
        Console.Write("Число вне рамок задачи");
        return;
    }
for (int i = 2; i <= a; i+=2) {
    if(i < a - 1) {
    Console.Write($"{i}, ");
    } else if(i == a - 1 || i == a) {
    Console.Write($"{i}");
    } else {
        Console.Write("you are lost");
    }
}