﻿using static Library;
/*Задача: Написать программу, 
которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] array1 = new string[7] {"Hello", "2", "world", ":-)", "1234", "-2", "computer science" };
string[] array2 = new string[array1.Length];
SecondArray(array1, array2);
PrintArray(array2);

