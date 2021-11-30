using System;

namespace DemoUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите что-нибудь");
            var strFromConsole = Console.ReadLine();
            Console.WriteLine(NewClass.SomeMethod(strFromConsole));
            
        }
    }
}