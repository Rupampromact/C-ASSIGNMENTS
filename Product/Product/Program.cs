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
        ProductList(String name, double price,int quantity,String type)
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
            Console.Write("Total no of products=" + count);

        }
    }
}
