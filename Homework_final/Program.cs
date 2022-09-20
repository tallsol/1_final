// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

string[] array1 = new string[4] {"hello", "2", "world", ":-)"};
string[] array2 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] array3 = new string[3] {"Russia", "Denmark", "Kazan"};

int Count (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) {count++;}
    }
    return count;
}

void PrintArray (string[] array)
{
    int count = Count(array);
    string[] arrayResult = new string [count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) {arrayResult[j] = array[i]; j++;}
    }
    Console.WriteLine($"[{String.Join(", ", arrayResult)}]");
}
Count(array1);
PrintArray(array1);
Count(array2);
PrintArray(array2);
Count(array3);
PrintArray(array3);