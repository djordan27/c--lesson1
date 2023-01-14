
int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine());
if(a > b) {
    Console.WriteLine($"max = {a}");
} else if (b > a) {
    Console.WriteLine($"max = {b}");
} else if (b == a) {
    Console.WriteLine("Числа равны");
} else {
    Console.WriteLine("Попробуйте снова!");
}