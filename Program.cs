// Задача: Написать программу,
// которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
// ["1234", "1567", "-2", "computer science"] → [“-2”]
// ["Russia", "Denmark", "Kazan"] → []

void printarray (string [] array)
{
    if (array.GetLength(0)==0)
    {
        return;
    }
    System.Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"\"{array[i]}\"");
        if (i < array.GetLength(0)-1)
        {
           System.Console.Write(" ");
        }
    }
    System.Console.WriteLine("]");
    return;
}

string[] createnewarray (string[] array)
{
    string[] arrnew = new string[0];
    for(int i=0; i<array.GetLength(0); i++)
    {
        if (array[i].Length<4)
        {
            arrnew=arrnew.Append(array[i]).ToArray();
        }
    }
    return arrnew;
}

string[] arr = {"1234", "1567", "-2", "computer science"};

System.Console.Write("исходный массив: ");
printarray(arr);
System.Console.WriteLine();

System.Console.WriteLine("преобразованный массив: ");
printarray(createnewarray(arr));