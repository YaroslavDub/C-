// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
if (first > second) {
    Console.WriteLine("Максимальное число: " + first);
    Console.WriteLine("Минимальное число: " + second);
}
else if (second > first) {
    Console.WriteLine("Максимальное число: " + second);
    Console.WriteLine("Минимальное число: " + first);
}
else {
    Console.WriteLine("Оба числа одинаковые");
}