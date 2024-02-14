//просто пример по выводу на экран 1:__________________________________________________________
System.Console.WriteLine("*******пример 1********");
System.Console.WriteLine("кол - во чисел: ");
int size1 = int.Parse(Console.ReadLine()!);// Вводим число (необходимое кол-во вводимых чисел) и парсим их переводя в int

int[] nambers2 = new int[size1];// принемаем введенное число в переменную

for (int i = 0; i < size1; i++) // функция по принятию чисел с консоли (кол-во чисел будет равно введенному значению в int size1)
{
    nambers2[i] = int.Parse(Console.ReadLine()!); // Записываем введенные значения
}

for (int i = 0; i < nambers2.Length; i++)// Функция по выводу значений на экран 
{
    Console.Write(nambers2[i]); // Выводим всегда nambers2[i] 
    if (i < nambers2.Length - 1) // проверка на последний элемент
    {
        System.Console.Write(", "); // Выводим запятую если элемент не последний
    }
}