// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
int nElement = 4;

string [] array = GetArray();
Console.WriteLine(string.Join(", ",array));

string [] GetArray()
{
    string [] result = new string [nElement];
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine("Введите "+i+" элемент массива");
        result[i]=Console.ReadLine();
    }
    return result;
}