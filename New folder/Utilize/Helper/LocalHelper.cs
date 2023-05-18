using System;
using System.Globalization;
namespace Utilize.Helper
{
    public static class LocalHelper
    {
        public static string ToFarsi(this string text)
        {
            try
            {
                return FarsiLibrary.Utils.toFarsi.Convert(text.Trim());
            }
            catch (Exception)
            {
                return string.IsNullOrEmpty(text) ? "" : text.Trim();
            }
        }

        //public static string ToFarsiNumericFormat(this string text)
        //{
        //    try
        //    {
        //        var str = FarsiLibrary.Utils.toFarsi.Convert(text.Trim());
        //        int j = 0;
        //        for (int i = 3; i < str.Length / 3; i++)
        //        {
        //            if ((i + j) % 3 == 0)
        //            {
        //                str = str.Insert(i + j, ",");
        //                j++;
        //            }
        //        }
        //        return str;
        //    }
        //    catch (Exception)
        //    {
        //        return string.IsNullOrEmpty(text) ? "" : text.Trim();
        //    }
        //}

        public static string ToEnglish(this string text)
        {
            try
            {
                return FarsiLibrary.Utils.toEnglish.Convert(text.Trim());
            }
            catch (Exception)
            {
                return string.IsNullOrEmpty(text) ? "" : text.Trim();
            }
        }

        public static string ToPersianDate(this DateTime dateTime)
        {
            var objPersianCalendar = new PersianCalendar();
            var year = objPersianCalendar.GetYear(dateTime);
            var month = objPersianCalendar.GetMonth(dateTime);
            var day = objPersianCalendar.GetDayOfMonth(dateTime);
            var hour = objPersianCalendar.GetHour(dateTime);
            var min = objPersianCalendar.GetMinute(dateTime);
            var sec = objPersianCalendar.GetSecond(dateTime);
            var result = year.ToString().PadLeft(4, '0') + "/" +
                         month.ToString().PadLeft(2, '0') + "/" +
                         day.ToString().PadLeft(2, '0');
            return result;
        }
    }
}
