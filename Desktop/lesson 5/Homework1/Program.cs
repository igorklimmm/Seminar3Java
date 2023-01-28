﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] FillArrayWithRandom(int [] array) // Метод, рандомные числа
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next (100, 1000);
    }
    return array;
}

int [] array = new int [4]; // 4 элемента
FillArrayWithRandom(array);
System.Console.WriteLine("Рандомный массив из трех чисел: ");
System.Console.WriteLine(string.Join(',' , array));
int n=0;

for (int i = 0; i < array.Length; i++)
{
   if( array[i]%2  == 0)
   n++;
}
System.Console.WriteLine("количество четных чисел в массиве: "+ n);
