using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Constants
{
    public static class Message
    {
        public static string MaintenanceTime = "Bakım Zamanı";

        #region CarMessage

        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarListed = "Arabalar Listelendi";
        public static string CarGetted = "Arabalar Getirildi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string NotReturnedCar = "Araba Teslim Edilmedi";
        public static string ReturnedCar = "Araba Kiralama Başarılı";

        #endregion

        #region BrandMessage
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandListed = "Marka Listelendi";
        public static string BrandGetted = "Marka Getirildi";
        public static string BrandUpdated = "Marka Güncellendi";
        #endregion

        #region ColorMessage
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListed = "Renk Listelendi";
        public static string ColorrGetted = "Renk Getirildi";
        public static string ColorrUpdated = "Renk Güncellendi";
        
        #endregion



    }
}
