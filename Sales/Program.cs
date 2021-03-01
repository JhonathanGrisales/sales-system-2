using System;


namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Store store = new Store();


            //sellers 

            Seller seller1 = new Seller();
            seller1.Name = "Juan";
            seller1.Age = 35;
            store.AddSeller(seller1);

            Seller seller2 = new Seller();
            seller2.Name = "Carlos";
            seller2.Age = 28;
            store.AddSeller(seller2);

            Seller seller3 = new Seller();
            seller3.Name = "Andres";
            seller3.Age = 45;
            store.AddSeller(seller2);

            //Products

            Product product1 = new Product();
            product1.Name = "mouse";
            product1.Price = 25000;
            store.AddProduct(product1);

            Product product2 = new Product();
            product2.Name = "keyboard";
            product2.Price = 34000;
            store.AddProduct(product2);

            Product product3 = new Product();
            product3.Name = "monitor";
            product3.Price = 29000;
            store.AddProduct(product3);

            Product product4 = new Product();
            product4.Name = "padmouse";
            product4.Price = 48000;
            store.AddProduct(product4);



            //sales

            Sale sale1 = new Sale();
            sale1.Product = product1;
            sale1.Seller = seller3;
            sale1.Comments = "without discount";
            store.AddSale(sale1);

            Sale sale2 = new Sale();
            sale2.Product = product2;
            sale2.Seller = seller2;
            sale2.Comments = "without discount";
            store.AddSale(sale2);

            Sale sale3 = new Sale();
            sale3.Product = product3;
            sale3.Seller = seller3;
            sale3.Comments = "without discount";
            store.AddSale(sale3);

            Sale sale4 = new Sale();
            sale4.Product = product4;
            sale4.Seller = seller3;
            sale4.Comments = "without discount";
            store.AddSale(sale4);

            Sale sale5 = new Sale();
            sale5.Product = product4;
            sale5.Seller = seller2;
            sale5.Comments = "without discount";
            store.AddSale(sale5);

            Sale sale6 = new Sale();
            sale6.Product = product1;
            sale6.Seller = seller1;
            sale6.Comments = "without discount";
            store.AddSale(sale6);




            //store.KnowEconomicProduct();



            System.Console.WriteLine("MENU");
            System.Console.WriteLine("1. Sales total amount ");
            System.Console.WriteLine("2. who has sold the cheapest product ");
            System.Console.WriteLine("3. Average price of products. ");
            System.Console.WriteLine("4. How many units of the product have been sold. ");
            System.Console.WriteLine("5. What's the most expensive product. \n ");



            string cases = Console.ReadLine();
            int caseSwitch = Convert.ToInt32(cases);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Menu 1 \n");
                    //SUMA TOTAL DE VENTAS
                    double total = sale1.Product.Price + sale2.Product.Price + sale3.Product.Price +
                    sale4.Product.Price + sale5.Product.Price + sale6.Product.Price;
                    System.Console.WriteLine("Sales total amount: " + total);

                    break;
                case 2:
                    Console.WriteLine("Menu 2 \n");
                    //NOMBRE DEL VENDEDOR QUE VENDIO PRODUCTO MAS BARATO 
                    store.SellerName();

                    break;
                case 3:
                    Console.WriteLine("Menu 3 \n");
                    //PROMEDIO DE PRODUCTOS 
                    store.AverageProducts();
                    break;
                case 4:
                    Console.WriteLine("Menu 4 \n");
                    //CUANTOS PRODUCTOS VENDIDOS 
                    System.Console.WriteLine("Enter any of the following: ");
                    System.Console.WriteLine("mouse");
                    System.Console.WriteLine("keyboard");
                    System.Console.WriteLine("monitor");
                    System.Console.WriteLine("padmouse \n");


                    System.Console.WriteLine("Enter product name");
                    string nameProduct = Console.ReadLine().ToLowerInvariant();
                    store.SoldUnits(nameProduct);

                    break;

                case 5:
                    Console.WriteLine("Menu 5 \n");
                    //PRODUCTO MAS COSTOSO 
                    store.ExpensiveProduct();
                    break;

                default:
                    Console.WriteLine("Wrong value");
                    break;
            }

        }
    }
}
