using System;
using System.Text.RegularExpressions;

public class Brace
{
    public static bool ValidBraces(string braces)
    {
        // Kapanış parantezlerini açan parantezlerle eşleştiren düzenli ifade
        string pattern = @"\(\)|\[\]|\{\}";

        // Eşleşen düzenli ifadeleri kaldırarak geçerli parantezler olup olmadığını kontrol ediyoruz
        while (Regex.IsMatch(braces, pattern))
        {
            braces = Regex.Replace(braces, pattern, "");
        }

        // Geçerli parantezlerin kalmış olup olmadığını kontrol ediyoruz
        return string.IsNullOrEmpty(braces);
    }
}

public class Program
{
    public static void Main()
    {

        while (true)
        {
            string xyz = Console.ReadLine();
            Console.WriteLine(Brace.ValidBraces(xyz));
        }
        // Test cases
        Console.WriteLine(Brace.ValidBraces("(){}[]")); // True
        Console.WriteLine(Brace.ValidBraces("([{}])")); // True
        Console.WriteLine(Brace.ValidBraces("(}")); // False
        Console.WriteLine(Brace.ValidBraces("[(])")); // False
        Console.WriteLine(Brace.ValidBraces("[({})](]")); // False
        Console.WriteLine(Brace.ValidBraces("()")); // True
        Console.WriteLine(Brace.ValidBraces(")(()))")); // False
        Console.WriteLine(Brace.ValidBraces("(")); // False
        Console.WriteLine(Brace.ValidBraces("(())((()())())")); // True
    }
}
