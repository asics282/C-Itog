// Написать программу, которая из имеющегося массива строк формирует массив из строк, меньше либо равна 3 символа

// Примеры: 
// ["hello", "2", "world", ":-)"] -> [ "2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// Author: asics28

void Main()
{Console.Clear();
Console.WriteLine("Данная программа сформирует из введенного вами массива новый, в котором длина элемента меньше либо равны 3 символа");
Console.WriteLine("Для старта нажмите Enter");
Console.ReadLine();
Console.Write("Введите количество элементов, которое хотите ввести: ");
int M = int.Parse(Console.ReadLine());
string [] array = new string[M];
FillArray(array);
Console.WriteLine();
Console.Write("Введенный массив: ");
Print(array);
Console.WriteLine();
Console.Write("Новый массив: ");
Print(NewArray(array));
Console.WriteLine();
Console.Write("Для завершения работы нажмите Enter");
Console.ReadLine();}

void FillArray (string [] array) // метод ввода элементов массива пользователем
{for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i+1}-ый элемент: "); // последовательный ввод элементов массива
    array[i] = (Console.ReadLine());
}}

string [] NewArray (string [] array) // метод формирования нового массива по условию
{int elementsCount = 0; // счетчик элементов подходящих под условие (меньше либо равна 3 символа)
foreach (var element in array)
{if (element.Length <= 3) {elementsCount++;}}

var index = 0;
var newArray = new string[elementsCount]; // новый массив для элементов подходящих под условие 

foreach (var element in array) // сборка нового массива из строк, меньше либо равным 3 символа
{if (element.Length <= 3) {newArray[index] = element; index++;}}
return newArray;}

void Print (string [] array) // метод "красиво" печатает одномерный массив
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < (array.Length - 1))
        {Console.Write($"{array[i]}, ");}
        else
        {Console.Write($"{array[i]}");}   
    }
}

Main();