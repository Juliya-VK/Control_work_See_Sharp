# Итоговая проверочная работа по See Sharp.

## Задача:
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

### Алгоритм решения:
Этот код решает задачу копирования строк из одного массива в другой, с условием копирования только строк, длина которых не превышает 3 символа. Прежде всего, задаются два массива строк array1 и array2, а также две функции: FillArray и ShowArray. FillArray принимает два массива строк в качестве аргументов. Она перебирает строки из source (исходного массива) и копирует их в target (целевой массив), только если длина строки не превышает 3 символа. Это делается с помощью переменной count, которая отслеживает индекс в target, чтобы вставить элементы без пропусков. ShowArray принимает массив строк и выводит его содержимое, игнорируя пустые строки или null, и выводит каждый элемент в кавычках. После определения функций происходит вызов FillArray с аргументами array1 и array2, после чего вызывается ShowArray для вывода содержимого массива array2

