using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {

           
            var products = new List<Products>();
            var items = new Products();

            products.Add(new Products() { Name = "Lettuce", Quantity = 10.5, Price = 50, Type = "Leafy green" });

            products.Add(new Products() { Name = "Cabbage", Quantity = 20, Price = 100, Type = "Cruciferous " });

            products.Add(new Products() { Name = "Pumpkin", Quantity = 30, Price = 30, Type = "Marrow" });

            products.Add(new Products() { Name = "Cauliflower", Quantity = 10, Price = 25, Type = "Cruciferous green" });

            products.Add(new Products() { Name = "Zucchini", Quantity = 20.5, Price = 50, Type = "Marrow green" });

            products.Add(new Products() { Name = "Yam", Quantity = 30, Price = 50, Type = "Root" });

            products.Add(new Products() { Name = "Spinach", Quantity = 10, Price = 100, Type = " Leafy green" });

            products.Add(new Products() { Name = "Broccoli", Quantity = 20.5, Price = 75, Type = "Cruciferous" });

            products.Add(new Products() { Name = "Garlic", Quantity = 30, Price = 20, Type = "Leafy green" });

            products.Add(new Products() { Name = "Silverbeet", Quantity = 10, Price = 50, Type = "Marrow green" });


            Console.WriteLine("The Total no Product in the list :" + products.Count);

            Console.WriteLine("After adding a new product the list stands here:");
            products.Add(new Products()
            { Name = "Potato", Quantity = 10, Price = 50, Type = "Root" });
            foreach (var product in products)
            {
                //   Console.WriteLine(items);
                Console.WriteLine(product.Name + " \t" + product.Price + " \t" + product.Quantity + " \t" + product.Type + " \t");
            }
            Console.WriteLine("The Total no Product in the list :\t" + products.Count);

            Console.WriteLine("Leafy products are:");
            foreach (var product in products)
            {
                if (product.Type == "Leafy green")
                {
                    Console.WriteLine(product.Name + " \t" + product.Price + " \t" + product.Quantity + " \t" + product.Type + " \t");
                }
            }

            Console.WriteLine("As garlic is sold out,the list stands here:");
            int i = 0;
            for (i = 0; i < products.Count; i++)
            {
                if (products[i].Name == "garlic")
                {
                    products.RemoveAt(i);
                }
            }

            foreach (var product in products)
            {
                Console.WriteLine(product.Name + " \t" + product.Price + " \t" + product.Quantity + "\t " + product.Type + " \t");
            }

            for (i = 0; i < products.Count; i++)
            {
                if (products[i].Name == "Cabbage")
                {
                    products[i].Quantity += 50;
                    Console.WriteLine("The Final Quantity of Cabbage in the inventory:\t" + products[i].Quantity);
                    break;
                }
            }
            double Total_bill = 0;
            foreach(var product in products)
            {
                if (product.Name == "Lettuce")
                { 
                    Total_bill += (1 * product.Price);
                }
                if (product.Name == "Zucchini")
                {
                    Total_bill += (2 * product.Price);
                }
                if (product.Name == "Broccoli")
                {
                    Total_bill += (1 * product.Price);
                }
            }
                Console.WriteLine("Total amount to be paid is :\tRs." + Total_bill);
                {

            }
}
            }
    }
    
