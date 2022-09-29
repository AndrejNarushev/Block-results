//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.WriteLine("<<Программа, которая из массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.>>");
Console.WriteLine();
Console.WriteLine("Выберите вариант работы.");
Console.WriteLine("1 - Задать кол-во и содержание массивов лично.");
Console.WriteLine("2 - Выполнить заданный массив.");
Console.Write("Введите вариант: ");
int len = 3;
int x = Convert.ToInt32(Console.ReadLine());

if(x!=1 && x!=2)
{
    Console.Clear();
    Console.WriteLine(" !!! Введен не верный вариант. Попробуйте заново. !!!");
}

else {
    if(x==1)                                         // вариант 2 (выполнение заданного массива)
        {
        Console.Clear(); 
        Console.Write("Укажите количество элементов (строк) в массиве: ");
        int size = Convert.ToInt32(Console.ReadLine());
        string[] a = new string[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Введите содержание {i+1}-й строки: ");         // создание массива
            string element = Convert.ToString(Console.ReadLine());
            a[i] = element;
        }

            string[] b = new string[size];
            int pos = 0;
            for (int j = 0; j < size; j++)                           // форматирование массива согласно условия
            {
                if (a[j].Length <= len)
                {
                b[pos] = a[j];
                pos++;
                }
            }

Console.Clear();
Console.WriteLine("Вариант №1");
Console.Write("Введен массив: ");
PrintArray(a);
Console.WriteLine("");
Console.Write("Сформированный массив: ");
PrintArray(b);
Console.Write("");
}

    if(x==2)                                        // вариант 2 (выполнение заданного массива)
        {
         Console.Clear();        
         Console.WriteLine("Вариант №2");
         string[] a = new string[7] {"Hello","2","world", ":-)","jh","Qwerty","ASD"};
         string[] b = new string[a.Length];

         void C (string[] a, string[] b)                  // форматирование массива согласно условия
         {int count =0;
         for (int i = 0; i < a.Length; i++)
            {
                if(a[i].Length <= len)
                {
                b[count] = a[i];
                count++;
                }
            }
        }
    
C(a, b);
Console.Write("Введен массив: ");
PrintArray(a);
Console.WriteLine();
Console.Write("Сформированный массив: ");
PrintArray(b);
Console.Write("");
    }
}
   
    void PrintArray(string[] array)                 // функция вывода на печать
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


