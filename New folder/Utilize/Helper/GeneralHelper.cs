using System;
using Infragistics;
using Infragistics.Win.UltraWinGrid;
using System.Linq;
namespace Utilize.Helper
{
	public static class GeneralHelper
	{
        /// <summary>
        /// در صورت خالی بودن متن ورودی مقدار"بدون عنوان" را بر میگرداند
        /// </summary>
        /// <param name="Text">متن ورودی</param>
        /// <returns> </returns>
        public static string GetTitle(this string Text)
        {
            return string.IsNullOrEmpty(Text.Trim()) ? "بدون عنوان" : Text.Trim();
        }

        public static string ReplaceArabicChar(this string Text)
        {
            return Text.Replace("ی", "ي").Replace("ک", "ك");
        }

        /// <summary>
        /// UltraGrid اعمال واحد ریالی (واحد، هزار، میلیون) بر روی ستون های مبلغ در گریدهای 
        /// 0: واحد
        /// 1: هزار
        /// 2: میلیون
        /// </summary>
        /// <param name="Text">متن ورودی</param>
        /// <returns> </returns>
        public static UltraGrid ApplyScale(this UltraGrid ugSWARTReport, int unit)
        {
            //return string.IsNullOrEmpty(Text.Trim()) ? "بدون عنوان" : Text.Trim();
            int scale = 1;
            switch (unit)
            {
                case 0:
                    scale = 1;
                    foreach (var column in
                        ugSWARTReport.DisplayLayout.Bands[0].Columns.Cast<UltraGridColumn>().Where(column => Equals(column.DataType, typeof(decimal))))
                    {
                        column.Format = "#,###";
                    }
                    break;
                case 1:
                    scale = 1000;
                    foreach (var column in
                        ugSWARTReport.DisplayLayout.Bands[0].Columns.Cast<UltraGridColumn>().Where(column => Equals(column.DataType, typeof(decimal))))
                    {
                        column.Format = "#,###,";
                    }
                    break;
                case 2:
                    scale = 1000000;
                    foreach (var column in
                        ugSWARTReport.DisplayLayout.Bands[0].Columns.Cast<UltraGridColumn>().Where(column => Equals(column.DataType, typeof(decimal))))
                    {
                        column.Format = "#,###,,";
                    }
                    break;
                case 3:
                    scale = 1000000000;
                    foreach (var column in
                        ugSWARTReport.DisplayLayout.Bands[0].Columns.Cast<UltraGridColumn>().Where(column => Equals(column.DataType, typeof(decimal))))
                    {
                        column.Format = "#,###,,,";
                    }
                    break;
            }
            return ugSWARTReport;
        }

        /// <summary>
        /// چک کردن اینکه متن خالی هست
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
	    public static bool IsNullOrEmptyByTrim(this string Text)
		{
		    return string.IsNullOrEmpty(Text) || string.IsNullOrEmpty(Text.Trim());
		}

        /// <summary>
        /// چک کردن Long بودن متن ورودی
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
	    public static bool IsNumber(this string Text)
		{
			long alaki;
			return Int64.TryParse(Text, out alaki);
		}

        /// <summary>
        /// در ابتدا موارد وارد شده در آرایه را از متن حذف کرده و سپس چک می کند که متن نهایی عدد است
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="RemoveItems"></param>
        /// <returns></returns>
		public static bool IsNumber(this string Text, string[] RemoveItems)
		{
			long alaki;
			foreach (var RemoveItem in RemoveItems)
			{
				Text = Text.Replace(RemoveItem, "");
			}
			return Int64.TryParse(Text, out alaki);
		}

        /// <summary>
        /// تبدیل متن به Long
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
		public static long ToLong(this string Text)
		{
			return Convert.ToInt64(Text);
		}

        /// <summary>
        /// تبدیل متن به Double
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static double ToDouble(this string Text)
        {
            return Convert.ToDouble(Text.Trim());
        }

        /// <summary>
        /// تبدیل متن به Int
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
		public static int ToInt(this string Text)
		{
			try
			{
				return Convert.ToInt32(Text);
			}
			catch
			{
				Routines.ShowErrorMessageFa("خطا", "خطا در ورود اطلاعات", MyDialogButton.OK);
				return -1;
			}
		}

        public static bool ToBoolean(this string Text)
        {
            try
            {
                return Convert.ToBoolean(Text.Trim());
            }
            catch
            {
                Routines.ShowErrorMessageFa("خطا", "خطا در ورود اطلاعات", MyDialogButton.OK);
                return false;
            }
        }

		public static string AddTextTostringIfIsNotEmpty(this string primText, string appText)
		{
			if (primText.IsNullOrEmptyByTrim())
				return primText;
			return primText + appText;
		}

		public static bool TryDateTime(this string txtPersianDate)
		{
			try
			{
				FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(txtPersianDate);
				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}
	}
}
