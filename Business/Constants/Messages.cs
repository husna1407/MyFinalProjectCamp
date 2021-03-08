using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //static yapınca new lemiyoruz.
    {
        public static string ProductAdded = "Ürün eklendi..!";
        public static string ProductNameInvalid = "Ürün ismi geçersiz..!"; //public ler genelde pascal case isimlendirilir.
        public static string MaintenanceTime = "Sistem Bakımda..!";
        public static string ProductsListed = "Ürünler Listelendi..!";
        public static string ProductCountOfCategoryError = "Kategorideki ürün limitini aştınız!";
        public static string ProductNameAlreadyExist = "Bu isimde ürün zaten var!";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldığından yeni ürün eklenemiyor!";
    }
}
