using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class Store
    {

        Seller[] Sellers = new Seller[5];
        int sellerCount = 0;

        Product[] Products = new Product[6];
        int productCount = 0;

        Sale[] SalesStore = new Sale[6];
        int saleCount = 0;

        public void AddSeller(Seller newSeller)
        {
            Sellers[sellerCount] = newSeller;
            sellerCount++;
        }

        public void AddProduct(Product newProduct)
        {
            Products[productCount] = newProduct;
            productCount++;
        }

        public void AddSale(Sale newSale)
        {
            SalesStore[saleCount] = newSale;
            saleCount++;
            
        }


        //CONOCER PRODUCTO MAS ECONOMICO
        public double KnowEconomicProduct()
        {

            //IDENTIFICO EL PRODUCTO MAS COSTOSO

            double higher = 0;
           

            for (int i = 0; i < productCount; i++)
            {


                if (Products[i].Price > higher)
                {

                    higher = Products[i].Price;

                }
            }


            //System.Console.WriteLine("More expensive " + higher);


            //IDENTIFICO EL PRODUCTO MAS BARATO

            double less = higher;
            


            for (int i = 0; i < productCount; i++)
            {
               

                if (Products[i].Price < less)
                {

                    less = Products[i].Price;

                }


            }

          
          //System.Console.WriteLine("More economical " + less);


            return less;
            


        }

        //CONOCER NOMBRE VENDEDOR 
        public void SellerName()
        {

            //PRODUCTO MAS BARATO
            double cheap = KnowEconomicProduct();

            for (int i = 0; i < saleCount; i++)
            {

                if (SalesStore[i].Product.Price == cheap)
                {

                    string name = SalesStore[i].Seller.Name;
                                       
                    System.Console.WriteLine("the cheapest product was sold by: " + name);

                }


            }

            
        }

        //PROMEDIO DE PRODUCTOS
        public void AverageProducts()
        {
            double sum = 0;

            for(int i = 0; i < productCount; i++ )
            {

                sum = sum + Products[i].Price;

            }

            double average = sum / productCount;
            System.Console.WriteLine("Average price of products: " + average);
        }



        //UNIDADES DE PRODUCTO VENDIDAS 
        public void SoldUnits(String name)
        {

            int count = 0;


            for (int i = 0; i < saleCount; i++)
            {


                if (SalesStore[i].Product.Name == name)
                {

                    count++;

                }

            }

            System.Console.WriteLine("Product units sold: " + count);




        }

        //PRODUCTO MAS COSTOS 
        public void ExpensiveProduct()
        {


            double higher = 0;
            string nameProductHigher = "";


            for (int i = 0; i < productCount; i++)
            {


                if (Products[i].Price > higher)
                {

                    higher = Products[i].Price;
                    nameProductHigher = Products[i].Name;

                }
            }

            System.Console.WriteLine("The most expensive product is: " + nameProductHigher);

        }







    }
}
