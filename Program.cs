using System;

public class StringComparisonExample
{
    public static void Main(string[] args)
    {
        string str1 = "Hello";
        string str2 = "hello";
        string str3 = "Hello World";
        string str4 = "Hello";


        // Compare() - сравнение строк с учетом регистра
        Console.WriteLine($"Compare(\"{str1}\", \"{str2}\"): {string.Compare(str1, str2)}"); //Результат будет не 0, т.к. регистр учитывается
        Console.WriteLine($"Compare(\"{str1}\", \"{str4}\"): {string.Compare(str1, str4)}"); //Результат будет 0

        // Equals() - сравнение строк с учетом регистра
        Console.WriteLine($"Equals(\"{str1}\", \"{str2}\"): {str1.Equals(str2)}"); // false
        Console.WriteLine($"Equals(\"{str1}\", \"{str4}\"): {str1.Equals(str4)}"); // true

        // CompareOrdinal() - сравнение строк без учета регистра и культуры
        Console.WriteLine($"CompareOrdinal(\"{str1}\", \"{str2}\"): {string.CompareOrdinal(str1, str2)}"); //Результат будет не 0, т.к. символы разные

        // IndexOf() - поиск подстроки
        Console.WriteLine($"IndexOf(\"World\" in \"{str3}\"): {str3.IndexOf("World")}"); // 6

        // Contains() - проверка на наличие подстроки
        Console.WriteLine($"Contains(\"World\" in \"{str3}\"): {str3.Contains("World")}"); // true

        // Операторы == и !=
        Console.WriteLine($"str1 == str2: {str1 == str2}"); // false
        Console.WriteLine($"str1 == str4: {str1 == str4}"); // true
        Console.WriteLine($"str1 != str2: {str1 != str2}"); // true
        Console.WriteLine($"str1 != str4: {str1 != str4}"); // false


        //Пример с игнорированием регистра в Equals
        Console.WriteLine($"Equals(\"{str1}\", \"{str2}\", StringComparison.OrdinalIgnoreCase): {str1.Equals(str2, StringComparison.OrdinalIgnoreCase)}"); // true

        //Пример с игнорированием регистра в Compare
        Console.WriteLine($"Compare(\"{str1}\", \"{str2}\", StringComparison.OrdinalIgnoreCase): {string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase)}"); //0

    }
}
