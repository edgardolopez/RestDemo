using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAPI.Statics
{
    public class Statics
    {
        public static IList<User> Users = new List<User>()
        {
            new User { UserName = "1", Password = "1" }
        };

        public static Product Product = new Product() { ProductId = "1", ProductDescription = "Un producto" };

        public static List<Product> Products =
            Enumerable.Range(1, 10).Select(x => new Product() {
                ProductId = x.ToString(),
                ProductDescription = "Producto " + x.ToString()
            }).ToList();


        public static String AuthenticationHeader = "Authentication";
    }
}