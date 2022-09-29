//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.WriteLine("<<Программа, которая из массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.>>");



string[] a = new string[4] {"Hello","2","world", ":-)"};
string[] b = new string[a.Length];
void C (string[] a, string[] b)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
    if(a[i].Length <= 3)
        {
        b[count] = a[i];
        count++;
        }
    }
}
void PrintB(string[] B)
{Console.Write(" [");
    for (int i = 0; i < B.Length; i++)
    {
        Console.Write($"{B[i]}");
        if (i < B.Length-3){
                Console.Write(",");}

    }
    Console.Write("]");
    Console.WriteLine();

    
}
C(a, b);
Console.WriteLine("Начальный массив:");
Console.WriteLine(" [Hello,2,world,:-)]");
Console.WriteLine("Сформированный массив:");
PrintB(b);