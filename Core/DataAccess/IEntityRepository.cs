using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint--Tyerine veritabanı nesnelerinden yazsın. Mesela 'int' yazarsa program kabul etmesin. bunu 'Where' koşulu ile yapacağız. 
    //':class' referans tip olabilir demek(sadece class demek değil)
    //':class, IEntity' deki, IEntity olabilir veya IEntity implement eden bir nesne olabilir.
    //':class, IEntity,new()' deki, newlenebilir olmalı.
    public interface IEntityRepository<T> where T:class,IEntity,new() //IProductDal ve ICategoryDal kullanmak yerine generic bir interface tanımladık ve bunu kullanacağız.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null); //x
        T Get(Expression<Func<T, bool>> filter); //y
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //List<T> GetAllByCategory(int categoryId); //x ve y satırlarını yazdığımızda bu satıra gerek kalmıyo. zaten yapmış oluyoruz.
    }
}
