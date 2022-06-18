﻿/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] array = new int[8];                           //Здесь вначале мы объявили массив nums, который будет хранить данные типа int. Далее используя операцию new, мы выделили память для 4 элементов массива: new int[4]. Число 4 еще называется длиной массива. При таком определении все элементы получают значение по умолчанию, которое предусмотренно для их типа. Для типа int значение по умолчанию - 0. 
void RandomArray(int[] array)                       //Соответственно,  здесь мы делаем метод "который ничего не принимает и что-то выдает". В данном случае для каждой итерации будет присваиваться новое значения для элемента массива до тех пор пока выполняется условие i< длины массива array
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");                             // Добавляем вывод "[" перед циклом , иначе эта скобка будет писаться перед каждой новой итерацией
    for (int i = 0; i < array.Length-1; i++)
    {
                Console.Write($"{array[i]}, ");
    }
   Console.Write($"{array[array.Length-1]}]");      // делаем -1 после цикла, чтобы корректно вывести на экран закрывающую скобку "]"
}
RandomArray(array);
PrintArray(array);












