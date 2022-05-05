// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите числа через пробел: ");

string lineNum = Console.ReadLine();
string[] arr = lineNum.Split();
int[] mass = new int [arr.Length];
int sum = 0;
{
for (int i = 0; i < mass.Length; i++)
    mass[i] = Convert.ToInt32(arr[i]);
for (int j = 0; j < mass.Length; j++)

    if (mass[j] > 0)
    sum++;    
}   
Console.WriteLine($" Количество чисел > 0: {sum}");
