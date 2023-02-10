// Задача. Имеется одномерный массив array из n элементов, требуется
//         найти элемент массива, равный find

// 1. Установить счетчик index в позицию 0
// 2. Если array[index] = find. алгоритмя завершил работу успешно.
// 3. Увеличить index yf 1
// 4. Если index < n, то перейти к шагу 2. В противном случае
//    алгоритмя завершил работу безуспешно.


// Решение с помощью генератора случайных числе и методов

// new int[10] = команда "создать целочисленный массив из 10 элементов"


void FillArray(int[] collection)// метод наполнения массива случайными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col) // метод вывода на печать массива
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; // new int[10] = создать массив int из 10 элементов

// Решение задачи:

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если в случайно сгенерированном массиве нет ни одного элемента, отвечающего
                      // условиям поиска, то счетчик(в данном случае position) принимают равным -1

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 44);
Console.WriteLine(pos);