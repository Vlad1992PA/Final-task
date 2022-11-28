// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* 
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина 
которых меныше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать 
на стирте выполнения алгоритма, При решении не рекомендуется пользоваться коллекциями, 
пучше обойтись исключительно массивами.
 */

int count = 4; // размер массива (можно поставить любой или при желание дать пользователю ввести с клавиатуры)
string[] arrya = new string[count];
int length_arrya = 3;


string GetArray() {
    Console.WriteLine("Введите элемент массива:");
    string array = Console.ReadLine();
    return array;
}

// Met_GetArray метод получил элементов массива
string[] MetGetArray() {
    for (int i = 0; i < count; i++)    {        arrya[i] = GetArray();    }
    return arrya;
}

string[] array = MetGetArray();

// met_new_array метод сравнение и получения нового масива
int MetСomparisonArray() {    
    int count2 = 0;
    for (int j = 0; j < count; j++)
    {        if (length_arrya <= array[j].Length)   {count2++;}    }
    return count2;
}

string[] MetNewArray()  {
    string[] arrya_end = new string[MetСomparisonArray()];
    int count3 = 0;
    for (int j = 0; j < count; j++)    {
        if (length_arrya <= array[j].Length)        {
            arrya_end[count3] = array[j];
            count3++;
        }
    }
    return arrya_end;
}

 string[] array4 = MetNewArray();

// Show_console() метод показывает результат записи нового массива;
Console.Write("Новый массив = ");
for (int i = 0; i < array4.Length; i++)
{
    if (i+1 < array4.Length) // +1 что бы к последниму элементу не добавлялась "," при выводе на экран
    { Console.Write(array4[i]+", ");}

    else { Console.Write(array4[i]);}    
}
