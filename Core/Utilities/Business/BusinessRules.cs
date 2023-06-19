using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //siz params verdiğiniz zaman Run() içerisine istediğiniz kadar IResult verebiliyorsunuz. parametre olarak.
        //params kullandığınızda istediğiniz kadar parametre verebilirsiniz demek
        //C# arka planda gönderdiğiniz parametreleri IResult array'ına atıyor.
        public static IResult Run(params IResult[] logics) //logics == iş kuralı
        {
            foreach (var logic in logics)
            {
                if (!logic.Success) 
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
