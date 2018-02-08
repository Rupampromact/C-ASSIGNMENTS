using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class ProductList
    {
        String name;
        double price;
        int quantity;
        String type;
        //initializing the instance variables
        ProductList(String name, double price, int quantity, String type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }
        public static void Main(string[] args)
        {
            var products = new List<ProductList>{
            new ProductList( "lettuce",10.5,50,"Leafy green"),
            new ProductList("cabbage",20,100,"Cruciferous"),
            new ProductList("pumpkin", 30,30, "Marrow"),
            new ProductList( "cauliflower", 10 , 25, "Cruciferous"),
            new ProductList( "zucchini", 20.5 , 50, "Marrow"),
            new ProductList( "yam", 30 , 50, "Root"),
            new ProductList( "spinach", 10 , 100, "Leafy green"),
            new ProductList( "broccoli", 20.2, 75, "Cruciferous"),
            new ProductList( "Garlic", 30 , 20, "Leafy green"),
            new ProductList( "silverbeet", 10 , 50, "Marrow")
            };
            int count = products.Count;
            Console.WriteLine("Total no of products=" + count);
            //adding new
            products.Add(new ProductList("potato", 10, 50, "Root"));
            //counting after changes
            Console.WriteLine("Total no of products=" + products.Count);
            //showing the list after changing
            foreach (var p in products)
                Console.WriteLine(p.name+" "+p.price+" "+p.quantity+" "+p.type);
            //checking leafy green
            Console.WriteLine("The Type leafy caabage are:");
            var leafy = products.Where(x => x.type == "Leafy green").ToList();
            foreach (var pr in leafy)
                Console.WriteLine(pr.name);
            Console.WriteLine("All Garlics are sold out");
            //Removing Garlic
            products.RemoveAt(8);
            Console.WriteLine("After removing Garlic:");
            foreach (var pr in products)
                Console.WriteLine(pr.name);
            Console.WriteLine("Total no of products after deletion=" + products.Count);
            //adding the no of cabbages
            Console.WriteLine("Quantity of cabbages after adding: ");
            var cab = products.Where(x => x.name == "cabbage").ToList();
            foreach (var c in cab)
                Console.WriteLine(c.quantity + 50);
            double total = 0;
            //calculating the total cost
            Console.WriteLine("The total cost of items is:");
                
            foreach (var item in products)
            {
                if (item.name == "lettuce")
                    total = total + item.price;
                if (item.name == "zucchini")
                    total = total + item.price;
                if (item.name == "broccoli")
                    total = total + (2 * item.price);
            }
                Console.WriteLine(Math.Round(total));
            

        }





        private static ProductList Find(List<ProductList> products, Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}

