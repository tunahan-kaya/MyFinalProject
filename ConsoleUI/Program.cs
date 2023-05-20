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
            ProductTest();
            //CategoryTest();   

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                System.Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result= productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    System.Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
            
        }
    }
}