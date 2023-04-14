using System;

namespace Pizza_UML2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.Test();
            Console.Write("Press any key to enter the main menu");
            Console.ReadKey();
            store.Run();
        }
    }
}
/*
 * @Author Muhammed Tastan
 * 
 * Zipped from https://github.com/jpandersen61/UML2
 */ 