using System;
using DoubleLinkedList.Data;


namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            var dLinkList = new DoubleLinkList<User>();


            Console.WriteLine("This program presents DoubleLinkedList based on generics!");

            Console.WriteLine("========================================================================================");

            Console.WriteLine("Here we add some new users to list");

            var userOne = new User("Bob", "Fogo");
            var userTwo = new User("Jill", "Baker");
            var userThree = new User("Max", "Bizzarous");

            dLinkList.PushFront(userOne);
            dLinkList.PushFront(userTwo);
            dLinkList.PushFront(userThree);

            Console.WriteLine("========================================================================================");

            Console.WriteLine("Here we delete userTwo from list");

            dLinkList.DeleteElement(2);

            Console.WriteLine("========================================================================================");

            Console.WriteLine("Amount of elements in list are {0}", dLinkList.ListLenght);

            Console.WriteLine("========================================================================================");

            Console.WriteLine("Are user Bob is in the list?");

            if(dLinkList.Contains(userOne))
            {
                Console.WriteLine("\nYes, he is");
            }
            else
            {
                Console.WriteLine("\nNo, he is not");
            }

            Console.WriteLine("\nAre user Jasmin is in the list?");

            var userFour = new User("Jasmin", "Havir");

            if (dLinkList.Contains(userFour))
            {
                Console.WriteLine("\nYes, he is");
            }
            else
            {
                Console.WriteLine("\nNo, he is not");
            }

            Console.WriteLine("========================================================================================");

            Console.WriteLine("And final task, convert the list to an array!");

            User[] usersArray = dLinkList.ToArray();

            Console.WriteLine("========================================================================================");

            Console.WriteLine("Thank you for your time and good luck, press any key to exit");
            Console.ReadKey();

        }
    }
}
