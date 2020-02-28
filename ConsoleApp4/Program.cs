using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Person : IPrint
    {
        public void print()
        {
            Console.WriteLine("It's a persoooon!!!");
        }

        class Teacher : IPrint
        {
            public void print()
            {
                Console.WriteLine("It's a teacheeeer!!!");
            }
        }

        class Student : IPrint, ISred
        {
            public int[] marks = { 5, 4, 5, 3, 2 };
            public void print()
            {
                Console.WriteLine("It's a studeeeeent!!!");
            }


            public int calculate()
            {
                int summa = 0;
                int count = 0;
                for (int a = 0; a < marks.Length; a++)
                {
                    summa = summa + marks[a];
                    count++;
                }
                return summa / count;
            }
        }

        interface IPrint
        {
            void print();
        }

        interface ISred
        {
            int calculate();
        }
        class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
