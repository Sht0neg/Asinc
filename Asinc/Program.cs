using System.Threading;

namespace Asinc

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread currentThread = Thread.CurrentThread;

            Console.WriteLine(currentThread.Name);
            currentThread.Name = "Main";
            Console.WriteLine(currentThread.Name);
            Console.WriteLine($"ID: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Запущен ли поток: {currentThread.IsAlive}");
            Console.WriteLine($"Приоритет: {currentThread.Priority}");
            Console.WriteLine($"Состояние: {currentThread.ThreadState}");

            //Thread.Sleep( 10000 );
            //Thread.SpinWait( 10000 );

            Thread thread1 = new(() => Console.WriteLine("Марк сделал дз?"));
            thread1.Start();

            Thread thread2 = new(Print);
            thread2.Start();

            Thread thread3 = new((message) => Console.WriteLine(message));
            thread3.Start("РКН");

            Thread thread4 = new(PrintCustom);
            thread2.Start("РКН");

        }

        static public void Print() {
            Console.WriteLine("Денис сделал дз");
        }

        static public void PrintCustom(object message){
            Console.WriteLine(message);
        }

        public static void Calc(object a) {
            if (a is int n)
            {
                Console.WriteLine(n * n);
            }
        }


        public class Person(string FirstName, string LastName);
    }
}
