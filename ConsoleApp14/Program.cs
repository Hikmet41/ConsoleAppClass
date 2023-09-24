using System;

public delegate void Func(string str);

public class MyClass
{
    private string inputString;

    public MyClass(string str)
    {
        inputString = str;
    }

    public void Space(string str)
    {
        string spacedString = string.Join("_", str.ToCharArray());
        Console.WriteLine(spacedString);
    }

    public void Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        Console.WriteLine(reversedString);
    }
}

public class Run
{
    public void runFunc(Func func, string str)
    {
        func.Invoke(str);
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string:");
        var str = Console.ReadLine();
        MyClass cls = new MyClass(str);

        Func funcDell = new Func(cls.Space);
        funcDell += cls.Reverse;

        Run run = new Run();
        run.runFunc(funcDell, str);
    }
}
