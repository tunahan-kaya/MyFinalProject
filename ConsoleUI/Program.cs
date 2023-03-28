using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Linq;

namespace Console
{
    //SOLID
    //Open closed p. : yaptıgın yazılıma yeni bir özellik ekliyosan(iş kuralı anlamında değil), mevcuttaki hiç bir koduna dokunamazsın.
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(50, 100)) 
            {
                System.Console.WriteLine(product.ProductName);
            }
            
        }
    }
}