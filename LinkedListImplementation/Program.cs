using System;

namespace LinkedListImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddLast(10);
            Console.WriteLine(list.ToString());

            list.AddLast(20);
            Console.WriteLine(list.ToString());

            list.AddLast(30);
            Console.WriteLine(list.ToString());

            list.AddLast(40);
            Console.WriteLine(list.ToString());

            list.DeleteLast();
            Console.WriteLine(list.ToString());

            list.DeleteFirst();
            Console.WriteLine(list.ToString());

            Console.WriteLine(list.Contains(10));
            Console.WriteLine(list.IndexOf(10));
            Console.WriteLine(list.GetSize());
            var array = list.ToArray();
            Console.WriteLine(list.ToString());
         
            
                                                   
        }
    }
}