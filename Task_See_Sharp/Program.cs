// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array1 = new string[4] { "hello", "2", "world", ":)" };
string[] array2 = new string[array1.Length];

void FillArray(string[] source, string[] target)
{
    int count = 0;
    for (int i = 0; i < source.Length; i++)
    {
        if (source[i].Length <= 3)
        {
            target[count] = source[i];
            count++;
        }
    }
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (!string.IsNullOrEmpty(array[i])) // Проверяем, что строка не пустая или не null
        {
            Console.Write($"\"{array[i]}\" "); // Выводим только непустые элементы в кавычках
        }
    }
    Console.WriteLine();
}
FillArray(array1, array2);
ShowArray(array2);
