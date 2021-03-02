using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarListed = "Araçlar Listelendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated = "Araç Güncellendi";

        public static string BrandAdded = "Model Eklendi";
        public static string BrandListed = "Modeller Listelendi";
        public static string BrandDeleted = "Model Silindi";
        public static string BrandUpdated = "Model Güncellendi";
        public static string BrandNameInvalid = "Model İsmi Geçersiz";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorListed = "Renkler Listelendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorNameInvalid = "Renk İsmi Geçersiz";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserListed = "Kullanıcı Listelendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserFirstNameInvalid = "Kullanıcı İsmi Geçersiz";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerListed = "Müşteri Listelendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string RentalAdded = "Kiralanan Araç Eklendi";
        public static string RentalListed = "Kiralanan Araç Listelendi";
        public static string RentalDeleted = "Kiralanan Araç Silindi";
        public static string RentalUpdated = "Kiralanan Araç Güncellendi";
        public static string ReturnDate = "Araç Kiralanamaz";
        public static string CarCountOfBrandError ="Model sayısı 15 ten fazla olamaz";
        public static string CarNameAlreadyExits="Bu isimde araç bulunmaktadır.";

        public static string ImageListed="Fotoğraflar Listelendi";
        public static string ImageDeleted="Fotoğraf Silindi";
        public static string ImageUpdated= "Fotoğraf Güncellendi";
        public static string ImageAdded="Fotoğraf Eklendi";
        public static string FailAddedImageLimit="En fazla 5 fatoğraf eklenebilir.";
        public static string ImagesAdded="Foroğraf Eklendi";

        public static string AuthorizationDenied="Yetkiniz Yok";
        public static string UserRegistered = "Kayıt Oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin ="Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
