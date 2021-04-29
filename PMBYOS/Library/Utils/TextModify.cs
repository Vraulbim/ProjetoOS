using System.Globalization;

namespace PMBYOS.Library.Utils
{
    public static class TextModify
    {
        public static string ToTittle(string e)
        {
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(e.ToLower());
        }

        public static string ToUpper(string e)
        {
            return ToUpper(e);
        }

        public static string ToLower(string e)
        {
            return ToLower(e);
        }

        public static int CountChars(string e)
        {
            return e.Length;
        }
    }
}
