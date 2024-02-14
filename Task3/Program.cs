/*  Задание 3. 
    Семинар 6. Массивы и строки
    Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди
    введённых букв гласных.
    Пример:
    “hello” => 2
    “world” => 1
*/

bool IsVowels(char chr)
{
    return chr == 'a' || chr == 'e' ||
           chr == 'i' || chr == 'o' ||
           chr == 'u' || chr == 'y';
}

int CountVowels(string str)
{
    int vowels = 0;
    foreach (char e in str)
    {
        if (IsVowels(e))
        {
            vowels++;
        }
    }
    return vowels;
}
System.Console.WriteLine("введите произвольную строку");
string str2 = Console.ReadLine()!;
int res = CountVowels(str2);
System.Console.WriteLine($"Количество гласных:{res}");


//просто пример:
System.Console.WriteLine();
//string input = Console.ReadLine()!;
string input = "1, 3, 5";


// int[] numbers = input.Split(", ").Select(x => int.Parse(x)).ToArray();
int[] numbers = input.Split(", ").Select(int.Parse).ToArray();

Console.WriteLine(string.Join(", ", numbers));