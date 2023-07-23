class Program
{
    public static void Main()
    {
        while (true) 
        {
            var x = Console.ReadLine();
            Console.WriteLine(MyClass.IsOrderedBraches(x));
        }
        
    }
}

class MyClass
{
    public static bool IsOrderedBraches(string chars)
    {
        var firstvalue = chars.FirstOrDefault();
        var lastValue = chars.LastOrDefault();


        if (chars.Length == 0) return false;
        if (firstvalue == ']' || firstvalue == '}' || firstvalue == ')') return false;
        if (lastValue == '[' || lastValue == '{' || lastValue == '(') return false;
        int suslu = 0;
        int koseli = 0;
        int parentez = 0;

        foreach (var brache in chars)
        {
            if (brache == ']' || brache == '[') koseli++;
            else if (brache == '}' || brache == '{') suslu++;
            else if (brache == '(' || brache == ')') parentez++;
            else return false;
        }


        if (parentez % 2 == 1 || suslu % 2 == 1 || koseli % 2 == 1) return false;

        return true;
    }
}
}
