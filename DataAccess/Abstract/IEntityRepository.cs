using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Generic constraint - Generic kısıtlama
    //class : referans tip olabilir
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new(): newlenebilir olmalı
    //(interfaceler newlenelemediği için T, IEntity'i kullanamaz sadece içindeki Product, Customer ve Category'i kullanabilir.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null); //expression linq filtreleri yazmamızı sağlıyor eğer filter=null iste filtre vermese de olur
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
