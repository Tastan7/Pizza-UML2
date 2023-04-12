using System;

namespace UML2
{
    public class Store
    {
        MenuCatalog menuCatalog;

        public Store()
        {
            menuCatalog = new MenuCatalog();
        }
        public void Test()
        {
            Pizza p = new Pizza() { Number = 1, Name = "Margharita", Price = 60 };
            menuCatalog.Create(p);

            p = new Pizza() { Number = 2, Name = "Pepperoni", Price = 65 };
            menuCatalog.Create(p);

            p = new Pizza() { Number = 3, Name = "Kebab", Price = 70 };
            menuCatalog.Create(p);

            menuCatalog.PrintMenu();
        }

        public void Run()
        {
            new UserDialog(menuCatalog).Run();
        }
    }
}