using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProduct
{
    class ProductSwitch
    {
        String name;
        double price;
        int quantity;
        String type;
        //initializing the instance variables
        ProductSwitch(String name, double price, int quantity, String type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }
        static void Main(string[] args)
        {

            var sproducts = new List<ProductSwitch>{
            new ProductSwitch( "lettuce",10.5,50,"Leafy green"),
            new ProductSwitch("cabbage",20,100,"Cruciferous"),
            new ProductSwitch("pumpkin", 30,30, "Marrow"),
            new ProductSwitch( "cauliflower", 10 , 25, "Cruciferous"),
            new ProductSwitch( "zucchini", 20.5 , 50, "Marrow"),
            new ProductSwitch( "yam", 30 , 50, "Root"),
            new ProductSwitch( "spinach", 10 , 100, "Leafy green"),
            new ProductSwitch( "broccoli", 20.2, 75, "Cruciferous"),
            new ProductSwitch( "Garlic", 30 , 20, "Leafy green"),
            new ProductSwitch( "silverbeet", 10 , 50, "Marrow")
            };
            Console.WriteLine("Press 0 for type checking");
            Console.WriteLine("Press 1 for calculating total prize");
            Console.WriteLine("Press 2 for calculating average prize");
            Console.WriteLine("Press 3 for identifying costly products");
            Console.WriteLine("Press 4 for Exit");
            while (true)
            {
                Console.WriteLine("Enter your choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 0:
                        FindTypeMatch();
                        break;
                    case 1:
                        CalculatePrize();
                        break;
                    case 2:
                        FindAVG();
                        break;
                    case 3:
                        SelectList();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }

                void FindTypeMatch()
                {
                    var ftype = sproducts.Where(x => x.type == "Leafy green").ToList();
                    var stype = sproducts.Where(x => x.type == "Cruciferous").ToList();
                    var ttype = sproducts.Where(x => x.type == "Marrow").ToList();
                    var ltype = sproducts.Where(x => x.type == "Root").ToList();
                    foreach (var f in ftype)
                        Console.WriteLine("The product and types are:" + " " + f.name + " " + f.type);
                    foreach (var g in stype)
                        Console.WriteLine("The product and types are:" + " " + g.name + " " + g.type);
                    foreach (var h in ttype)
                        Console.WriteLine("The product and types are:" + " " + h.name + " " + h.type);
                    foreach (var i in ltype)
                        Console.WriteLine("The product and types are:" + " " + i.name + " " + i.type);
                }

                void CalculatePrize()
                {
                    double total_price = 0;
                    foreach (var s in sproducts)
                        total_price = total_price + (s.price * s.quantity);
                    Console.WriteLine("The total price of the inventory is:" + total_price);
                }
                void FindAVG()
                {
                    double avg_price = 0;
                    foreach (var t in sproducts)
                        avg_price = avg_price + (t.price * t.quantity);
                    Console.WriteLine("The average price of the inventory is:" + avg_price / sproducts.Count);
                }
                void SelectList()
                {
                    var costly = sproducts.Where(X => X.price * X.quantity > 50).ToList();
                    var cheap = sproducts.Where(Y => Y.price * Y.quantity < 50).ToList();
                    foreach (var s in costly)
                        Console.WriteLine("The list of costly products are:" + " " + s.name + " " + s.price * s.quantity);
                    foreach (var p in cheap)
                        Console.WriteLine("The list of cheap products are:" + " " + p.name + " " + p.price * p.quantity);
                }
            
            }


        }
    }


