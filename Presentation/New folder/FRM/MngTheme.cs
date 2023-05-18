using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar;
using Utilize.Helper;

namespace Presentation
{
    public enum Theme
    {
        Office2007Blue = 0,
        Office2007Silver = 1,
        Office2007Black = 2,
        Office2007VistaGlass = 3,
        Office2010Silver = 4,
        Office2010Blue = 5,
        Office2010Black = 6,
        Windows7Blue = 7,

    }
    public static class MngTheme
    {
        private const string Theme_Key = "Theme_Key : ";
        private const string Size_Of_Report_Key = "Size_Of_Report : ";
        private const string ColorHint_Key = "ColorHint_Key : ";
        private const string ExpandMenu_Key = "ExpandMenu_Key : ";
        private const string Split_Key = ";";
        private static RibbonControl RibbonControl;

        public static void Initialize(this StyleManager manager, out int tIndex, out Color cHint, out bool isExpand,RibbonControl ribbonControl)
        {
            RibbonControl = ribbonControl;
            tIndex = 0;
            cHint = Color.Empty;
            isExpand = false;
            var rootDirectory = Environment.CurrentDirectory + @"\Config";
            var filePath = rootDirectory + @"\Customize.dat";
            if (Directory.Exists(rootDirectory) == false)
                Directory.CreateDirectory(rootDirectory);
            if (File.Exists(filePath) == false)
            {
                File.Create(filePath).Dispose();
            }
            var reader = new StreamReader(filePath);
            var cusText = reader.ReadToEnd();
            reader.Dispose();
            reader.Close();
            var items = cusText.Split(Convert.ToChar(Split_Key));
            foreach (var item in items)
            {
                if (item.Contains(Theme_Key))
                {
                    var themeIndex = item.Substring(Theme_Key.Length).Trim().ToInt();
                    tIndex = themeIndex;
                    //manager.ChangeThame(themeIndex);
                }
                if (item.Contains(ColorHint_Key))
                {
                    var strColsAtt =
                        item.Substring(ColorHint_Key.Length).ToUpper().Replace("COLOR [", "").Replace("]", "").Trim().
                            Split(',');
                    var A =
                        strColsAtt.Where(sca => sca.Contains("A")).Select(it => it.Trim().Substring(2).ToInt()).
                            FirstOrDefault();
                    var R =
                        strColsAtt.Where(sca => sca.Contains("R")).Select(it => it.Trim().Substring(2).ToInt()).
                            FirstOrDefault();
                    var G =
                        strColsAtt.Where(sca => sca.Contains("G")).Select(it => it.Trim().Substring(2).ToInt()).
                            FirstOrDefault();
                    var B =
                        strColsAtt.Where(sca => sca.Contains("B")).Select(it => it.Trim().Substring(2).ToInt()).
                            FirstOrDefault();
                    var color = Color.FromArgb(A, R, G, B);
                    cHint = color;
                    //manager.ChangeColorHint(color);
                }
                if (item.Contains(ExpandMenu_Key))
                {
                    try
                    {
                        isExpand = item.Substring(ExpandMenu_Key.Length).Trim().ToBoolean();
                    }
                    catch
                    {
                        isExpand = false;
                    }
                    SetExpand(isExpand);
                }
            }
        }

        public static void SetExpand(bool isExpand)
        {
            RibbonControl.Expanded = isExpand;
        }

        public static void SaveCustomize(int themeIndex, Color colorHint,bool isExpand)
        {
            var rootDirectory = Environment.CurrentDirectory + @"\Config";
            var filePath = rootDirectory + @"\Customize.dat";
            if (Directory.Exists(rootDirectory) == false)
                Directory.CreateDirectory(rootDirectory);
            if (File.Exists(filePath) == false)
            {
                File.Create(filePath).Dispose();
            }
            var writer = new StreamWriter(filePath, false, Encoding.UTF8);
            var cus = "";
            cus += Theme_Key + themeIndex + Split_Key;
            cus += ColorHint_Key + colorHint + Split_Key;
            cus += ExpandMenu_Key + isExpand + Split_Key;
            writer.Write(cus);
            writer.Dispose();
            writer.Close();
        }
        public static void ChangeThame(this StyleManager styleManager, Theme theme)
        {
            switch ((int)theme)
            {
                case 0:
                    styleManager.ManagerStyle = eStyle.Office2007Blue;
                    break;
                case 1:
                    styleManager.ManagerStyle = eStyle.Office2007Silver;
                    break;
                case 2:
                    styleManager.ManagerStyle = eStyle.Office2007Black;
                    break;
                case 3:
                    styleManager.ManagerStyle = eStyle.Office2007VistaGlass;
                    break;
                case 4:
                    styleManager.ManagerStyle = eStyle.Office2010Silver;
                    break;
                case 5:
                    styleManager.ManagerStyle = eStyle.Office2010Blue;
                    break;
                case 6:
                    styleManager.ManagerStyle = eStyle.Office2010Black;
                    break;
                case 7:
                    styleManager.ManagerStyle = eStyle.Windows7Blue;
                    break;
                default:
                    styleManager.ManagerStyle = eStyle.Office2010Silver;
                    break;
            }
        }

        public static void ChangeThame(this StyleManager styleManager, int theme)
        {
            try
            {
                switch (theme)
                {
                    case 0:
                        styleManager.ManagerStyle = eStyle.Office2007Blue;
                        break;
                    case 1:
                        styleManager.ManagerStyle = eStyle.Office2007Silver;
                        break;
                    case 2:
                        styleManager.ManagerStyle = eStyle.Office2007Black;
                        break;
                    case 3:
                        styleManager.ManagerStyle = eStyle.Office2007VistaGlass;
                        break;
                    case 4:
                        styleManager.ManagerStyle = eStyle.Office2010Silver;
                        break;
                    case 5:
                        styleManager.ManagerStyle = eStyle.Office2010Blue;
                        break;
                    case 6:
                        styleManager.ManagerStyle = eStyle.Office2010Black;
                        break;
                    case 7:
                        styleManager.ManagerStyle = eStyle.Windows7Blue;
                        break;
                    default:
                        styleManager.ManagerStyle = eStyle.Office2010Silver;
                        break;
                }
            }
            catch (Exception)
            {
                
                //throw;
            }
        }

        public static void ChangeColorHint(this StyleManager styleManager, Color color)
        {
            styleManager.ManagerColorTint = color;
        }

        public static string GetSizeOfGetReport()
        {
            var rootDirectory = Environment.CurrentDirectory + @"\Config";
            var filePath = rootDirectory + @"\Customize.dat";
            if (Directory.Exists(rootDirectory) == false)
                Directory.CreateDirectory(rootDirectory);
            if (File.Exists(filePath) == false)
            {
                File.Create(filePath).Dispose();
            }
            var reader = new StreamReader(filePath);
            var cusText = reader.ReadToEnd();
            reader.Dispose();
            reader.Close();
            var items = cusText.Split(Convert.ToChar(Split_Key));
            foreach (var item in items)
            {
                if (!item.Contains(Size_Of_Report_Key)) continue;
                return item.Substring(Size_Of_Report_Key.Length);
            }
            return "100000";
        }

        public static bool GetExpandMenu()
        {
            var rootDirectory = Environment.CurrentDirectory + @"\Config";
            var filePath = rootDirectory + @"\Customize.dat";
            if (Directory.Exists(rootDirectory) == false)
                Directory.CreateDirectory(rootDirectory);
            if (File.Exists(filePath) == false)
            {
                File.Create(filePath).Dispose();
            }
            var reader = new StreamReader(filePath);
            var cusText = reader.ReadToEnd();
            reader.Dispose();
            reader.Close();
            var items = cusText.Split(Convert.ToChar(Split_Key));
            foreach (var item in items)
            {
                if (!item.Contains(ExpandMenu_Key)) continue;
                return Convert.ToBoolean(item.Substring(ExpandMenu_Key.Length).Trim());
            }
            return false;
        }
    }
}
