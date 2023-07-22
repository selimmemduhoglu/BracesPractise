public class Program
{
    public static void Main()
    {
        while (true)
        {
            string _test = Console.ReadLine();
            Console.WriteLine(Brace.ValidBraces(_test));
        }
    }
}

public class Brace
{
    public static bool ValidBraces(string braces)
    {
        while (braces.Contains("()") || braces.Contains("[]") || braces.Contains("{}"))
        {
            braces = braces.Replace("()", "");
            braces = braces.Replace("[]", "");
            braces = braces.Replace("{}", "");
        }
         
        return braces.Length == 0;
    }
}
