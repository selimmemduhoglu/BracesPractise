using System;
using System.Collections.Generic;



public class Program
{
    public static void Main()
    {
        while (true)
        {
            string xyz= Console.ReadLine();
            Console.WriteLine(Brace.ValidBraces(xyz));
        }
    }
}

public class Brace
{
    public static bool ValidBraces(string braces)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char brace in braces)
        {
            if (brace == '(' || brace == '[' || brace == '{')
            {
                stack.Push(brace);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false; // There is no matching opening brace
                }

                char top = stack.Pop();

                if ((brace == ')' && top != '(') || (brace == ']' && top != '[') || (brace == '}' && top != '{'))
                {
                    return false; // The closing brace does not match the opening brace
                }
            }
        }

        return stack.Count == 0; // If there are still opening braces in the stack, the string is invalid
    }
}



// Test cases
//Console.WriteLine(Brace.ValidBraces("([{}])")); // True
//Console.WriteLine(Brace.ValidBraces("(}")); // False
//Console.WriteLine(Brace.ValidBraces("[(])")); // False
//Console.WriteLine(Brace.ValidBraces("[({})](]")); // False
//Console.WriteLine(Brace.ValidBraces("()")); // True
//Console.WriteLine(Brace.ValidBraces(")(()))")); // False
//Console.WriteLine(Brace.ValidBraces("(")); // False
//Console.WriteLine(Brace.ValidBraces("(())((()())())")); // True

/*Stack sınıfı, verilerin son giren ilk çıkan (Last-In, First-Out - LIFO) prensibine göre işlendiği veri yapısını
 * temsil eder. Yani, en son eklenen eleman, yığından en önce çıkarılacaktır. Bu tür veri yapıları, verilerin 
 * belirli bir sırayla işlenmesi gereken durumlarda oldukça faydalıdır.
Stack sınıfı, .NET Framework tarafından sağlanır ve C# dilinde kolayca kullanılabilir. Öğeleri bir yığında eklemek
(push) ve yığından çıkarmak (pop) için kullanılan temel işlevleri sağlar.
Bu özel durumdaki örnekte, Stack<char> türünden bir yığın oluşturduk. Bu yığın, parantezlerin açılış sırasını takip
etmek için kullanılır. Açılış parantezleri (yani (, [, {) yığına eklenirken, kapanış parantezleri (yani ), ], })
yığın üstündeki en son eklenen açılış paranteziyle eşleşip eşleşmediğini kontrol etmek için kullanılır.
Bu yığın, algoritmanın düzgün çalışmasını sağlayarak parantezlerin doğru bir şekilde eşleşip eşleşmediğini kontrol
etmemizi sağlar. Ayrıca, yığında açık parantezlerin kalıp kalmadığını kontrol ederek, dizedeki parantezlerin 
eksiksiz bir şekilde eşleştiğini doğrular. Eğer yığın boş değilse ve dize sonlandığında hala açık parantezler varsa,
dize geçersiz kabul edilir. Aksi takdirde, eğer yığın boşsa, dize doğru kabul edilir.*/