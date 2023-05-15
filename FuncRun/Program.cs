using System;
using System.Diagnostics.Metrics;

namespace FuncRun
{
    public delegate void Func(string str);
    public class MyClass
    {
        public void Space(string str)
        {
            string spaced_string = string.Join("_", str.ToCharArray());
            Console.WriteLine(spaced_string);
        }

        public void Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversed_string = new string(charArray);
            Console.WriteLine(reversed_string);
        }
    }

    public class Run
    {
        public void runFunc(Func funcDel, string str)
        {
            funcDel(str);
        }
    }

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string:");
            string? str = Console.ReadLine();

            MyClass cls = new MyClass();

            Func funcDel = null;
            funcDel += cls.Space;
            funcDel += cls.Reverse;

            Run run = new Run();
            run.runFunc(funcDel, str);
        }
    }
 






}