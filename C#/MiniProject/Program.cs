using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{

    internal class Program
    {
        static List<Cart> cart = new List<Cart>();
        static void Main(string[] args)
        {
            int ch;
            while(true)
            {
                Console.WriteLine("1.Display Soups ");
                Console.WriteLine("2.Display Starters ");
                Console.WriteLine("3.Display Main Course");
                Console.WriteLine("4.Display Desserts");
                Console.WriteLine("5.Display Cart");
                Console.WriteLine("6.Exit");
                Console.Write("Enter your choice: ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:DisplaySoup();break;
                    case 2:DisplayStarter();break;
                    case 3:DisplayMainCourse();break;
                    case 4:DisplayDessert();break;
                    case 5: DisplayCart(); break;
                    case 6:Environment.Exit(0);break;
                    default: Console.WriteLine("Invalid Choice.....");break;
                }
            }
        }

        //Soups
        public static void DisplaySoup()
        {
            List<Soup> soups = new List<Soup>
            {
                new Soup{Id = 101, Name = "Tomato Soup", Price = 100},
                new Soup{Id = 102, Name = "Corn Soup", Price = 120},
                new Soup{Id = 103, Name = "Chicken Soup", Price = 180},
                new Soup{Id = 104, Name = "Mutton Soup", Price = 200},
            };
            Console.WriteLine("SoupID" + "\t" + "Soup Name" + "\t" + "Price" );
            Console.WriteLine("======" + "\t" + "=========" + "\t" + "=====");
            foreach (Soup s in soups)
            {
                Console.WriteLine(s.Id + "\t" + s.Name + "\t" + s.Price);
            }
            //Adding to Cart
            Console.Write("Enter Soup ID to select: ");
            int SoupID = Convert.ToInt32(Console.ReadLine());
            if(SoupID != 0)
            {
                Soup soupSelected = soups.FirstOrDefault(items => items.Id == SoupID);  
                if(soupSelected != null)
                {
                    AddToCart(new Cart { Id = soupSelected.Id, Name = soupSelected.Name, Price = soupSelected.Price });
                }
                else
                {
                    Console.WriteLine("Invalid Soup ID......");
                }
            }
            Console.WriteLine();
        }

        //Starters
        public static void DisplayStarter()
        {
            List<Starter> starters = new List<Starter>
            {
                new Starter{Id = 201, Name = "Cheeseballs", Price = 200},
                new Starter{Id = 202, Name = "Mushroom Tikka", Price = 180},
                new Starter{Id = 203, Name = "Corn Chaat", Price = 150},
                new Starter{Id = 204, Name = "Chicken Tikka", Price = 240},
                new Starter{Id = 205, Name = "Grill Chicken", Price = 340},
                new Starter{Id = 206, Name = "Meat Balls", Price = 280},
            };

            Console.WriteLine("StarterID" + "\t" + "Starter Name" + "\t\t" + "Price");
            Console.WriteLine("=========" + "\t" + "============" + "\t\t" + "=====");
            foreach (Starter st in starters)
            {
                Console.WriteLine(st.Id + "\t\t" + st.Name + "\t\t" + st.Price);
            }
            //adding to cart
            Console.Write("Enter Starter ID to select: ");
            int starterId = Convert.ToInt32(Console.ReadLine());
            if (starterId != 0)
            {
                Starter starterSelected = starters.FirstOrDefault(items => items.Id == starterId);
                if (starterSelected != null)
                {
                    AddToCart(new Cart { Id = starterSelected.Id, Name = starterSelected.Name, Price = starterSelected.Price });
                }
                else
                {
                    Console.WriteLine("Invalid Starter ID.....");
                }
            }
            Console.WriteLine();
        }

        //Main Course
        public static void DisplayMainCourse()
        {
            List<MainCourse> mc = new List<MainCourse>
            {
                new MainCourse{Id = 301, Name = "Chicken Biryani", Price = 220 },
                new MainCourse{Id = 302, Name = "Mutton Biryani", Price = 300 },
                new MainCourse{Id = 303, Name = "Veg Biryani", Price = 150 },
                new MainCourse{Id = 304, Name = "Egg Biryani", Price = 180 },
                new MainCourse{Id = 305, Name = "Veg Meals", Price = 120 },
                new MainCourse{Id = 306, Name = "Non-Veg Meals", Price = 200 },
            };
            Console.WriteLine("MainCourseID" + "\t" + "MainCourse Name" + "\t\t" + "Price");
            Console.WriteLine("============" + "\t" + "===============" + "\t\t" + "=====");
            foreach (MainCourse MC in mc)
            {
                Console.WriteLine(MC.Id + "\t\t" + MC.Name + "\t\t" + MC.Price);
            }
            //Adding to cart
            Console.Write("Enter MainCourse ID to select: ");
            int MainID = Convert.ToInt32(Console.ReadLine());
            if (MainID != 0)
            {
                MainCourse mainCourseSelected = mc.FirstOrDefault(items => items.Id == MainID);
                if (mainCourseSelected != null)
                {
                    AddToCart(new Cart {Id = mainCourseSelected.Id, Name = mainCourseSelected.Name, Price = mainCourseSelected.Price});
                }
                else
                {
                    Console.WriteLine("Invalid MainCourse ID.....");
                }
            }
        }

        //Desserts
        public static void DisplayDessert()
        {
            List<Dessert> desserts = new List<Dessert>
            {
                new Dessert{Id = 401, Name = "Pasteries", Price = 50},
                new Dessert{Id = 402, Name = "Brownies ", Price = 80},
                new Dessert{Id = 403, Name = "IceCreams", Price = 150},
                new Dessert{Id = 404, Name = "GulabJamun", Price = 100},
            };
            Console.WriteLine("DessertID" + "\t" + "Dessert Name" + "\t\t" + "Price");
            Console.WriteLine("=========" + "\t" + "============" + "\t\t" + "=====");
            foreach (Dessert des in desserts)
            {
                Console.WriteLine(des.Id + "\t\t" + des.Name + "\t\t" + des.Price);
            }
            //Adding to cart
            Console.Write("Enter Dessert ID to select: ");
            int dessertId = Convert.ToInt32(Console.ReadLine());
            if ( dessertId != 0)
            {
                Dessert dessertSelected = desserts.FirstOrDefault(items => items.Id == dessertId);
                if ( dessertSelected != null )
                {
                    AddToCart(new Cart { Id = dessertSelected.Id, Name = dessertSelected.Name, Price = dessertSelected.Price });  
                }
                else
                {
                    Console.WriteLine("Invalid Dessert ID.....");
                }
            }
            Console.WriteLine();
        }

        //Cart
        public static void DisplayCart()
        {
           
            Console.WriteLine("Items in Cart:");
            Console.WriteLine("ItemID" + "\t\t" + "Item Name" + "\t\t" + "Price");
            Console.WriteLine("======" + "\t\t" + "=========" + "\t\t" + "=====");
            foreach (Cart c in cart)
            {
                Console.WriteLine(c.Id + "\t\t" + c.Name + "\t\t" + c.Price);
            }
            // Calculate total bill amount
            double total = cart.Sum(item => item.Price);
            Console.WriteLine("Total Amount: "+total);
            Console.WriteLine();
        }

        //Adding items to cart
        public static void AddToCart(Cart items)
        {
            cart.Add(items);
            Console.WriteLine("Items Added Successfully......");
            Console.WriteLine();
        }
    }
}
