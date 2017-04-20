using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //리스트를 생성
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Name="감자", Price = 500
                },
                 new Product()
                {
                    Name="고구마", Price = 1500
                },
                  new Product()
                {
                    Name="양파", Price = 2500
                },
                   new Product()
                {
                    Name="토마토", Price = 200
                },
                    new Product()
                {
                    Name="배추", Price = 3500
                }
            };
            products.Sort(sortprice); //sort메소드에 매개변수로 sortwithprice메소드가 전달, 즉 델리게이트

            foreach (var item in products)
            {
                Console.WriteLine(item.Name + item.Price);
            }
        }

            static int sortprice(Product a, Product b)
            {
                return a.Price.CompareTo(b.Price);
            }
    }
}
