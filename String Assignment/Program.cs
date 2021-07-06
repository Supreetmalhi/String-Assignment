using System;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c, d, e, f, g, h;
            a = "My Name ";
            b = "is ";
            c = "Supreet.";
            d = a + b + c;
            Console.WriteLine(d);
            Console.WriteLine(d.ToUpper());

            e = " I am a student of Academy of Learning.";
            f = " I am learning C# in this course.";
            g = " Learning C# is fun.";

            h = string.Concat(d, e, f, g);
            Console.WriteLine(h);
        }
    }
}
