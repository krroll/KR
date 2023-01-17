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

// Размерность массива
int nElement = 4;

string [] array = GetArray();
if (FindElement(array)[0] == String.Empty)
Console.WriteLine("[]");
else
Console.WriteLine(string.Join(", ",FindElement(array)));

string [] GetArray()
{
    string [] result = new string [nElement];
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine("Введите "+(i+1)+" элемент массива");
        result[i]=Console.ReadLine();
    }
    return result;
}

string [] FindElement (string [] array)
{
    string [] threeSymbol = {""};
    int numArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            threeSymbol[numArray]=array[i];
            numArray++;
            if (i+1 < array.Length)
            Array.Resize(ref threeSymbol, threeSymbol.Length + 1);
        }    
    }
    return threeSymbol;
}