using System;

public class Brace
{
    public static bool ValidBraces(string braces)
    {
        int countRound = 0;
        int countSquare = 0;
        int countCurly = 0;

        foreach (var brace in braces)
        {
            switch (brace)
            {
                case '(':
                    countRound++;
                    break;
                case ')':
                    countRound--;
                    break;
                case '[':
                    countSquare++;
                    break;
                case ']':
                    countSquare--;
                    break;
                case '{':
                    countCurly++;
                    break;
                case '}':
                    countCurly--;
                    break;
                default:

                    return false; // Tanımsız karakter
            }

            // Herhangi bir sayacın negatif olması, kapanış parantezinin önceden gelmesi anlamına gelir ve dize geçersizdir.
            if (countCurly < 0 || countRound < 0 || countSquare < 0)
            {
                return false;
            }
        }

        // Tüm sayacın sıfır olması, tüm parantezlerin doğru eşleştiği anlamına gelir ve dize geçerlidir.
        return countRound == 0 && countCurly == 0 && countSquare == 0;
    }
}

public class Program
{
    public static void Main()
    {
        while (true)
        {
            var x = Console.ReadLine();
            Console.WriteLine(Brace.ValidBraces(x));
        }
    }
}
