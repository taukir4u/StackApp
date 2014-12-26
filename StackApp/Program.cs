using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> nameStack = new Stack<string>();
            nameStack.Push("Taukir");
            nameStack.Push("Hasan");
            nameStack.Push("Topu");
            nameStack.Push("Aysa");
            nameStack.Push("Siddika");
            nameStack.Push("Tondra");

            Console.WriteLine("Pushing Names into Stack: ");
            foreach (var aName in nameStack)
            {
                Console.WriteLine(aName); 
            }

            Console.WriteLine("Total Value: " + nameStack.Count);
            Console.WriteLine();


            Console.WriteLine("Popping Names from Stack: ");
            int count = nameStack.Count;

            for (var i = 0; i < count; i++)
            {
                Console.WriteLine(nameStack.Pop());
            }
            
            Console.WriteLine("Total Value: " + nameStack.Count);
            Console.ReadKey();
        }
    }
}
