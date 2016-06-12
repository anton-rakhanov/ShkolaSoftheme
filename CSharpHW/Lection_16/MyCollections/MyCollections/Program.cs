using System;
using MyCollections.Collections;
//using MyCollections.Collections.DictionaryElement;


namespace MyCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program presents manual collections such as Queue, Stack and Dictionary.");

           
            Console.WriteLine("========================================================================================");

           
            Console.WriteLine("Stack presentation: ");
            Console.WriteLine("\nPush to stack: ");

            
            var stack = new Stack<string>();

            
            for(int i = 0; i < 10; i++)
            {
                stack.Push("String number: " + i);
                Console.WriteLine("String number: " + i);
            }


            Console.WriteLine("\nPop from stack: ");


            while(!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }


            Console.WriteLine("========================================================================================");


            Console.WriteLine("Queue presentation: ");


            Console.WriteLine("\nEnqueue to queue: ");

            var queue = new Queue<double>();


            for (int i = 0; i < 10; i++)
            {
                var dValue = i + 0.8358;
                queue.Enqueue(dValue);
                Console.WriteLine(dValue);
            }

            Console.WriteLine("\nDequeue from queue: ");

            while(!queue.IsEmpty())
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine("========================================================================================");

            
            Console.WriteLine("Dictionary presentation: ");


            var dictionary = new Dictionary<string, int>();


            Console.WriteLine("\nAdd to dictionary 4 combinations of KeyValue");

            
            dictionary.Add("First", 213);
            dictionary.Add("Second", 847);
            dictionary.Add("Third", 345);
            dictionary.Add("Fourth", 767);

           
            Console.WriteLine("\nTry to add key-value combination that already in dictionary");

            
            dictionary.Add("Second", 847);

            
            Console.WriteLine("\nRemove from dictionary Third-345");

            
            if(dictionary.Remove("Third"))
            {
                Console.WriteLine("\nCombination with key: Third where removed");
            }


            Console.WriteLine("\nContains dictionary key: Fifth?");

            
            if (dictionary.Contains("Fifth"))
            {
                Console.WriteLine("\nYes");
            }
            else
            {
                Console.WriteLine("\nNo");
            }


            Console.WriteLine("\nThank you for your time, pleas press any key to exit..");
            Console.ReadKey();

        }
    }
}
