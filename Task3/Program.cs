/*  Задание 3. 
    Семинар 6. Массивы и строки
    Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди
    введённых букв гласных.
    Пример:
    “hello” => 2
    “world” => 1
*/

bool IsVowels(char chr) // Булева функция для проверки символа гласный(true) или нет(false)
{
    return chr == 'a' || chr == 'e' ||
           chr == 'i' || chr == 'o' ||
           chr == 'u' || chr == 'y'; // Двойное "или" для поиска и проверки равенства
}

int CountVowels(string str)
{
    int vowels = 0;
    foreach (char e in str)
    {
        if (IsVowels(chr: e))
        {
            vowels++;
        }
    }
    return vowels;
}
System.Console.WriteLine("введите произвольное слово в строке");
string str = Console.ReadLine()!;
int res = CountVowels(str);
System.Console.WriteLine($"Количество гласных: {res}");