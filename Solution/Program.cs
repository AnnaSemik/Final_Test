/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer sciense"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[m];

void array(string[] stringArray)               //Ввод данных в массив.
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine();
    }
}
string[] symbol(string[] stringArray)     // Cчитает количество элементов массива с тремя и менее символами и создает массив нужной размерностью и вносит данные из введенного массива в результат функции.
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            n++;
    }
    string[] rez = new string[n];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            rez[j] = stringArray[i];
            j++;
        }
    }
    return rez;
}
void printA(string[] stringArray)    // Вывод на экран значений массива.
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{stringArray[i]} ");
    }
    Console.Write("]");
}
array(stringArray);
printA(symbol(stringArray));

