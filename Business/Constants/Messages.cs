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
        internal static string MaintenanceTime = "Sistem Bakımda..!";
        internal static string ProductsListed = "Ürünler Listelendi..!";
    }
}
