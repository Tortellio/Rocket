using System.Linq;

namespace Rocket.API.Extensions
{
    public static class RocketCommandExtensions
    {
        public static string GetStringParameter(this string[] array, int index)
        {
            return (array.Length <= index || string.IsNullOrEmpty(array[index])) ? null : array[index];
        }

        public static int? GetInt32Parameter(this string[] array, int index)
        {
            return (array.Length <= index || !int.TryParse(array[index].ToString(), out int output)) ? null : (int?)output;
        }

        public static uint? GetUInt32Parameter(this string[] array, int index)
        {
            return (array.Length <= index || !uint.TryParse(array[index].ToString(), out uint output)) ? null : (uint?)output;
        }

        public static byte? GetByteParameter(this string[] array, int index)
        {
            return (array.Length <= index || !byte.TryParse(array[index].ToString(), out byte output)) ? null : (byte?)output;
        }

        public static ushort? GetUInt16Parameter(this string[] array, int index)
        {
            return (array.Length <= index || !ushort.TryParse(array[index].ToString(), out ushort output)) ? null : (ushort?)output;
        }

        public static float? GetFloatParameter(this string[] array, int index)
        {
            return (array.Length <= index || !float.TryParse(array[index].ToString(), out float output)) ? null : (float?)output;
        }

        public static string GetParameterString(this string[] array, int startingIndex = 0)
        {
            if (array.Length - startingIndex <= 0) return null;
            return string.Join(" ", array.ToList().GetRange(startingIndex, array.Length - startingIndex).ToArray());
        }

    }
}
