using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAppBackEnd.Business.Constants
{
    public class Messages
    {
        public static string ErrorMessage = "Bir Hata Oluştu! Hata İçeriği: ";

        public static string IdNotFound = "Id Bulunamadı!";

        public static string RecordIsNotFound = "Kayıt Bulunamadı!";
        public static string RecordIsAdded = "Kayıt Başarıyla Eklendi!";
        public static string RecordIsNotAdded = "Kayıt Eklenemedi!";
        public static string RecordIsDeleted = "Kayıt Başarıyla Silindi!";
        public static string RecordIsNotDeleted = "Kayıt Silinemedi!";
        public static string RecordIsUpdated = "Kayıt Başarıyla Güncellendi";
        public static string RecordIsNotUpdated = "Kayıt Güncellenemedi!";

        public static string RecordsIsNotAddedToRedis = "Kayıtlar Redise Eklenemedi!";
        public static string ListNotFound = "Liste Bulunamadı!";
    }
}
