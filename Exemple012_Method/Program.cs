// Вид 1. Метод не имеет аргументов и ничего не возвращает
/*
void Method1()
{
    Console.WriteLine("Автор ...");
}

Method1(); // метод вызывается введением имени метода с пустыми (),
//            используется если нужно вывести, например, подпись
*/


// Вид 2. Метод на вход берет аргументы, но ничего не возвращает
//используется, если нужно произвести какие-то операции с аргументом, а результат вывести на экран
// также можно вывести на экран несколько аргументов.

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i =0;
//     while ( (i < count))
//     {
//         Console.WriteLine(msg);
//         i++;  // инкримент, уменьшение на единицу - деккримент
//     }    
// }
// Method21(msg: "Текст", count: 4);


// Вид 3. Метод Ничего не принимает, но возвращает

// Необходимо обозначить тип возвращаемых данных и обязательно return

// int Method3()
// {
//     return DateTime.Now.Year;    
// }

// int year = Method3();
// Console.WriteLine(year);


// Вид 4. Метод, который принимает на вход аргументы и возвращает 
// результат их обработки.
/*
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty; // функция выдает пустую строку типа string

    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;    
}

string res = Method4(10, "asdf");
Console.WriteLine(res);
*/

// Цикл for

// string Method4(int count, string c)
// {
//     string result = String.Empty; // функция выдает пустую строку типа string
//     for (int i = 0; i < count; i++)
//     {
//         result = result + c;        
//     }
//     return result;    
// }

// string res = Method4(10, "z"); //порядок аргументов при вызове метода не важен
// Console.WriteLine(res);

// Цикл в цикле. Напишите таблицу умножения.

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// Задача. Дан текст. В тексте нужно все пробелы заменить черточками
// маленькие буквы "к" заменить большими "К", а большие "С" заменить
// маленькими "с"

// string text = " - Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послали вместо нашего милого Винценгроде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();


// Упорядочить массив от минимального элемента к максимальному
/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/

// Упорядочить массив от максимального элемента к минимальному

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
