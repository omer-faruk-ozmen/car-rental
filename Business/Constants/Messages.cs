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
    static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarDeleted;
        public static string ListedCars = "Araçlar listelendi";
        public static string AllBrandIdFilter;
        public static string AllColorIdFilter;
        public static string CarGetById;
        public static string GetByUnitPriceFiltered;
        public static string AllCarDetails;
        public static string CarUpdated;
        public static string WarningHour = "Erişime kısıtlı saat";
        public static string BrandAdded;
        public static string BrandDeleted;
        public static string BrandGetById;
        public static string BrandGetAll = "Araç markaları listelendi";
        public static string BrandUpdated;
        public static string ColorAdded;
        public static string ColorDeleted;
        public static string ColorGetAll;
        public static string ColorUpdated;
        public static string ColorGetById;
        public static string UserAdded;
        public static string UserDeleted;
        public static string UserGetAll;
        public static string UserGetById;
        public static string UserUpdated;
        public static string RentalAdded;
        public static string RentalDeleted;
        public static string VehicleNotDelivered;
        public static string RentalGetById;
        public static string RentalUpdated;
        public static string CustomerAdded;
        public static string CustomerDeleted;
        public static string CustomerGetById;
        public static string CustomerUpdated;
        public static string RentalFailAdded="Kiralık araç ekleme başarısız.";
        public static string UserGetByMail;
        public static string AccessTokenCreated="Token oluşturuldu.";
        public static string UserAlreadyExists="Kullanıcı zaten kayıtlı.";
        public static string UserRegistered = "Kullanıcı kayıt edildi.";
        public static string UserNotFound="Kullanıcı Bulunamadı.";
        public static string PasswordError="Kullanıcı adı veya şifre hatalı.";
        public static string SuccessfulLogin="Giriş başarılı.";
        public static string AuthorizationDenied="Yetkisiz işlem.";
    }
}
