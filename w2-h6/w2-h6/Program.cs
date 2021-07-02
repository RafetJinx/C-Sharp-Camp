using System;

namespace w2_h6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Rafet = new Product("rafet");
            Product Berkay = new Product("berkay");
            Product Seda = new Product("seda");
            Product Salih = new Product("salih");

            Product[] products = { Rafet, Berkay, Seda, Salih };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].name);
            }

            foreach (Product product in products)
            {
                Console.WriteLine(product.name);
            }

            int j = products.Length - 1;

            while (j >= 0)
            {
                Console.WriteLine(products[j].name);
                j--;
            }
        }

        class Product
        {
            public string name;
            public Product(string name)
            {
                this.name = name;
            }
        }
    }
}
