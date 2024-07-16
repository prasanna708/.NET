using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _15JulyTask_2
{
    internal class Program
    {
        //Creating list of Product type
         static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            //Creating objects and assigning values
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Apple";
            product1.Price = 70;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Mango";
            product2.Price = 90;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Grapes";
            product3.Price = 50;

            //Adding Products to List
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            DisplayAllProducts();

            Console.WriteLine("------------------------------------------------");
            int ch;
            while (true)
            {
                Console.WriteLine("1. Add new Product ");
                Console.WriteLine("2. Display All products ");
                Console.WriteLine("3. Display Product by Id ");
                Console.WriteLine("4. Update Product ");
                Console.WriteLine("5. Delete a product ");
                Console.WriteLine("6. Exit ");
                Console.Write("enter your choice(1-6):");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1: AddProduct(); break;
                    case 2: DisplayAllProducts(); break;
                    case 3: DisplayProductById(); break;
                    case 4: UpdateProduct(); break;
                    case 5: DeleteProductById(); break;
                    case 6: Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Invalid choice..!");
                        break;
                }
            }
        }

        //1. Add new Product
        static void AddProduct()
        {
            Product product = new Product();

            Console.Write("Enter Product Id: ");
            product.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            product.Name = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            product.Price = Convert.ToDouble(Console.ReadLine());

            products.Add(product);  //Adding Products to list

            Console.WriteLine("Product Added Successfully........");
            Console.WriteLine("------------------------------------------------");
        }

        //2. Display All products
        static void DisplayAllProducts()
        {
            Console.WriteLine("List of Products: ");
            Console.WriteLine("ID \t Name \t Price");
            Console.WriteLine("=== \t ==== \t =====");
            //Printing Products in list
            foreach (Product product in products)
            {
                Console.WriteLine(product.Id + "\t" + product.Name + "\t" + product.Price);
            }
            Console.WriteLine("------------------------------------------------");
        }

        //3. Display Product by Id
        static void DisplayProductById()
        {
            int tempid;
            Console.Write("Enter Product ID: ");
            tempid = Convert.ToInt32(Console.ReadLine());
            int count = 0;  
            foreach (Product prod in products)
            {
                if (prod.Id == tempid)
                {
                    Console.WriteLine("Product Name: "+prod.Name);
                    Console.WriteLine("Product Price: "+prod.Price);
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Product not found.....ss");
            }
            Console.WriteLine("------------------------------------------------");
        }

        //4. Update Product
        static void UpdateProduct()
        {
            
        }

        //5. Delete a product
        static void DeleteProductById()
        {
            Product dp = new Product();

            Console.Write("Enter Product Id: ");
            int tid = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            foreach (Product dprod in products)
            {
                if(tid == dprod.Id)
                {
                    products.Remove(dprod);
                    Console.WriteLine("Product deleted successfully.....");
                    count++;
                    break ;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Product not found.....");
            }
            Console.WriteLine("------------------------------------------------");
        }
        
    }
}
