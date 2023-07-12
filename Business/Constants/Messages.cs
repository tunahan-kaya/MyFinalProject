using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages //static verdiğimizde newlemiyoruz
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        internal static string CategoryLimitExceded = "Kategory Limiti aşıldığı için yeni ürün eklenemiyor.";
        internal static string AuthorizationDenied = "Yetkiniz yok.";
        internal static string UserRegistered = "Kayıt oldu";
        internal static string UserNotFound = "Kullanıcı Bulunamadı";
        internal static string PasswordError = "Hatalı Şifre";
        internal static string SuccessfulLogin = "Başarılı giriş ";
        internal static string UserAlreadyExists = "Zaten böyle bir kullanıcı var";
        internal static string AccessTokenCreated = "Giriş jetonu oluşturuldu";
    }
}
