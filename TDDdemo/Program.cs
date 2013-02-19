using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDdemo
{
    class Program
    {

        static void Main(string[] args)
        {
            Box box = new Box();

            box.Push("a", 10);
            box.Push("b", 10);
            box.Push("c", 100);

            box.List();
            Console.WriteLine(box.Pop());
            Console.ReadLine();
        }

    }
}
