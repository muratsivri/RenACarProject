using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi en az 2 karakter olmalıdır.";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductListed = "Ürünler listelendi";
        public static string RentalAdded = "Araç eklendi";
        public static string RentalDeleted = "Araç silindi";
        public static string RentalUpdated = "Araç güncellendi";
        public static string RentalInvalid = "Araç teslim edilmedi";
        public static string RentalsListed = "Araçlar listelendi";
        public static string UserAdded = "Kulllanıcı eklendi";
        public static string UserDeleted = "Kulllanıcı silindi";
        public static string UserUpdated = "Kulllanıcı güncellendi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşteri listelendi";
        public static string CarImageAdded = "Araba resmi başarıyla eklendi!";
        public static string CarImageDeleted = "Araba resmi başarıyla silindi";
        public static string CarImageUpdated = "Araba resmi başarıyla güncellendi!";
        public static string ImageLimitExceded = "Bir arabanın en fazla 5 resmi olabilir!";

        public static string AuthorizationDenied="Yetkiniz yok";
        internal static string UserRegistered="Kullanıcı kayıt oldu";
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
