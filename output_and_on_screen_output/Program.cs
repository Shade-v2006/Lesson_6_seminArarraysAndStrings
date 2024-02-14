﻿//просто пример 1:__________________________________________________________
System.Console.WriteLine(); // для перехода на новую строку
System.Console.WriteLine("*******пример 1********"); // для красоты

//string input = Console.ReadLine()!; // Вводим с консоли числа через ", " (запятую с пробелом)
string input = "1, 3, 5"; // Что бы каждый раз не вводить - как пример

var result = input.Split(", ");// Считываем кол - во ", " (введенных запятых с пробелом)

foreach (var e in result) // Перебераем считанные числа
{
    System.Console.Write(e + " "); // Выводим считанные числа
}

//просто пример 2:__________________________________________________________
System.Console.WriteLine(); // для перехода на новую строку
System.Console.WriteLine("*******пример 2********"); // для красоты

//string input = Console.ReadLine()!; // Вводим с консоли числа через ", " (запятую с пробелом)
string input2 = "1, 3, 5"; // Что бы каждый раз не вводить - как пример

int[] numbers = input2.Split(", ").Select(x => int.Parse(x)).ToArray();//можно добавить .sum - и он суммирует все элементы -
/* Считываем кол - во ", " (введенных запятых с пробелом), перебираемые элементы превращаем в < x > и < x > парсим (превращаем в число) , 
и записываем в массив (.Select(x => int.Parse(x)) - это лямбда выражение (анонимное))*/

//int[] numbers = input.Split(", ").Select(int.Parse).ToArray(); //Считываем кол - во ", " (введенных запятых с пробелом), Парсим, записываем в массив

// System.Console.WriteLine(numbers); // Если добавлен .sum в 22 строке
Console.WriteLine(string.Join(";\t ", numbers)); //

//string sep = ", " // создаем переменную для символов
// Console.WriteLine(string.Join(sep, numbers)); // тоже самое что и в 29 строке только с переменной


// int MyFunc(string input) // (.Select(x => int.Parse(x)) - это лямбда выражение (анонимное) - та же функция не анонимная
// {
//     return int.Parse(input);
// }
// int[] numbers = input2.Split(", ").Select(x => MyFunc(input: x)).ToArray();

//________________________________________________________________________
// x.ToLower() или x.ToUpper() - Выражения добавляются в int.Parse(x.ToLower()) - преобразование в верхний или нижний регистр(большие или маленькие буквы)

//______К Домашнему заданию_____________________________________________ 
// if 'A' <= ch <= 'Z'
// ch -= 'a' - 'A'