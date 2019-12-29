using System;

namespace CallByValueVsCallByReference
{
    class Program
    {
 
             public void ChangeSize(int size)
            {

                size *= 5;
            }

            public static void ChangeSize(ref int size)
            {
                size*= 5;

            }

            static void Main(string[] args)
            {
                Program p = new Program();
                int size = 12;
                Console.WriteLine("Main's size is {0}", size);
                p.ChangeSize(size);
                Console.WriteLine("Method's size is " + size);
                Console.WriteLine("Main's size is now " + size);

                Console.WriteLine();

                Console.WriteLine("Main's size is " + size);
                ChangeSize(ref size);
                Console.WriteLine("Method's size is " + size);
                Console.WriteLine("Main's size is now " + size);

            int[] array = { 1, 2, 3 };
            Console.WriteLine(Class1.add(array)); 
            }
        }
    }


