using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Utilize.Maps.IranMap
{
    public class MapInfo
    {

        private readonly Bitmap bmpMain;
        private readonly Bitmap bmpSecond;
        private readonly ItemMapInfo[] item;
        private readonly Color ColorMain;

        public Bitmap Main { get { return bmpMain; } }
        public Color Color { get { return ColorMain; } }

        public Dictionary<int, string> GetIndexsByName()
        {
            var dictionary= item.ToDictionary(itemMapInfo => itemMapInfo.Index, itemMapInfo =>GetDescription(itemMapInfo.Index));
            return dictionary;
        }

        public  MapInfo()
        {
            string s;
            bmpMain = new Bitmap(Properties.Resources.Iran_Ostan1);

            int count = 30;

            item = new ItemMapInfo[count];

            int i;
            s = Properties.Resources.strMapInf;
            var array=s.Split(new[] {';'});
            for (i = 0; i < count; i++)
            {
                
                var ss = array[i].Split(new[] {' '});
                if (ss.Length < 7)
                    throw new Exception(string.Format("Format of file  is error!"));
                item[i].DrawX = Int32.Parse(ss[0]);
                item[i].DrawY = Int32.Parse(ss[1]);
                item[i].BeginX = Int32.Parse(ss[2]);
                item[i].BeginY = Int32.Parse(ss[3]);
                item[i].Width = Int32.Parse(ss[4]);
                item[i].Height = Int32.Parse(ss[5]);
                item[i].Text = ss[6];
                item[i].Index = i;
            }
        }

        public double MinRed = 10, MaxGrean=9.99,MinGrean=5, MaxYelow=4.99, MinYeliw=0;

        public Bitmap SetValu(int index, int CountriesValue, Bitmap bmpHelper)
        {
            //         foreach (var CountryValue in CountriesValue)
            //         {

            using (Graphics g = Graphics.FromImage(bmpHelper))
            {
                var imi = item[index];
                if (CountriesValue >= MinRed)
                {
                    g.DrawImage(Properties.Resources.REDMap,
                                new Rectangle(imi.DrawX, imi.DrawY, imi.Width, imi.Height),
                                imi.BeginX, imi.BeginY, imi.Width, imi.Height, GraphicsUnit.Pixel);
                    return bmpHelper;
                }
                if (CountriesValue <= MaxGrean && CountriesValue >= MinGrean)
                {
                    g.DrawImage(Properties.Resources.GreenMap,
                                new Rectangle(imi.DrawX, imi.DrawY, imi.Width, imi.Height),
                                imi.BeginX, imi.BeginY, imi.Width, imi.Height, GraphicsUnit.Pixel);
                    return bmpHelper;
                }
                if (CountriesValue <= MaxYelow && CountriesValue >= MinYeliw)
                {
                    g.DrawImage(Properties.Resources.YelowMap,
                                new Rectangle(imi.DrawX, imi.DrawY, imi.Width, imi.Height),
                                imi.BeginX, imi.BeginY, imi.Width, imi.Height, GraphicsUnit.Pixel);
                    return bmpHelper;
                }
            }
            return bmpHelper;
        }

        public int InArea(int x, int y)
        {
            Color c;
            int k = 0;
            foreach (ItemMapInfo imi in item)
            {
                int i = x - imi.DrawX;
                int j = y - imi.DrawY;
                if (i >= 0 && i <= imi.Width && j >= 0 && j <= imi.Height)
                {
                    i += imi.BeginX;
                    j += imi.BeginY;
                    if (i < bmpSecond.Width && j < bmpSecond.Height)
                    {
                        c = bmpSecond.GetPixel(i, j);
                        if (c.A != 0)
                        {
                            return k;
                        }
                    }
                }
                k++;
            }
            return -1;
        }

        public Image Hit(int Index)
        {
            var bmpHelper = new Bitmap(Main);
            ItemMapInfo imi = item[Index];

            using (Graphics g = Graphics.FromImage(bmpHelper))
            {
                g.DrawImage(bmpSecond, new Rectangle(imi.DrawX, imi.DrawY, imi.Width, imi.Height),
                               imi.BeginX, imi.BeginY, imi.Width, imi.Height, GraphicsUnit.Pixel);
            }
            return bmpHelper;
        }

        internal string GetDescription(int Index)
        {
            return item[Index].Text;
        }
    }
    
    public struct ItemMapInfo
    {
        public int DrawX, DrawY;
        public int Width, Height;
        public int BeginX, BeginY;
        public string Text;
        public int Index;
    }
}
