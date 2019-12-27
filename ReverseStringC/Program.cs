using System;
using System.Linq;

namespace ReverseStringC
{
    class Program
    {
        //hello
        static void Main(string[] args)
        {
            string inputString = "all cows eat grass";
            string resultString = string.Join(" ", inputString
                .Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));

            Console.WriteLine(resultString);

        }
    }
}
