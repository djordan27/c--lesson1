/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
int a = Convert.ToInt32(Console.ReadLine());
Boolean even = true;

if(a % 2 == 0 && a != 0) {
    Console.WriteLine($"{a} -> {even}");
} else if(a == 0){
    even = false;
    Console.WriteLine($"{a} -> {even}");
} else {
    even = false;
    Console.WriteLine($"{a} -> {even}");
}
