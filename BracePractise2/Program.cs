using System;

public class Brace
{
    public static bool ValidBraces(string braces)
    {
        char[] stack = new char[braces.Length];
        int top = -1;

        foreach (char brace in braces)
        {
            if (brace == '(' || brace == '[' || brace == '{')
            {
                stack[++top] = brace;
            }
            else
            {
                if (top == -1)
                {
                    return false; // Eşleşen açılış parantez yok
                }

                char topChar = stack[top--];

                if ((brace == ')' && topChar != '(') || (brace == ']' && topChar != '[') || (brace == '}' && topChar != '{'))
                {
                    return false; // Kapanış parantezi açılış paranteziyle eşleşmiyor
                }
            }
        }

        return top == -1; // Eğer hala açık parantezler varsa, dize geçersizdir
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
    }
}
