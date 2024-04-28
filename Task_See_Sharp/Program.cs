// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

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

