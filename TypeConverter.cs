using System.Data;
using System.Drawing;
using System.Reflection.Metadata;

namespace SharpStackConvert
{
    public static class TypeConverter
    {
        /// <summary>
        /// This method converts the input to Decimal. If the input is null or empty, it returns 0.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this object? input)
        {
            string strInput = input == null ? "" : input.ToString();


            decimal ret = 0;
            if (string.IsNullOrEmpty(strInput)) { return 0; }
            decimal.TryParse(strInput, out ret);
            return ret;
        }

        /// <summary>
        /// This method converts the input to a double. If the input is null or empty, it returns 0.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double ToDouble(this object? input)
        {
            string strInput = input == null ? "" : input.ToString();

            double ret = 0;
            if (string.IsNullOrEmpty(strInput)) { return 0; }
            double.TryParse(strInput, out ret);
            return ret;
        }

        /// <summary>
        /// This method converts the input to a string. Going to be deprecated. Use ToSString instead.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CString(this object? input)
        {
            if (input == null) return "";
            if (input is decimal)
                return input.ToDecimal().ToSString();
            if (input is double)
                return input.ToDouble().ToSString();

            return input.ToString();
        }

        /// <summary>
        /// This method converts the input to a string. If the input is null, it returns an empty string.
        /// </summary>
        /// <param name="input">The object to convert to a string.</param>
        /// <returns>The string representation of the object.</returns>
        public static string ToSString(this object? input)
        {
            return CString(input);
        }

        /// <summary>
        /// This method converts the input to an integer. If the input is null or empty, it returns 0.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int ToInt32(this object? input)
        {
            string strInput = input == null ? "" : input.ToString();

            int ret = 0;
            if (string.IsNullOrEmpty(strInput)) { return 0; }
            if (int.TryParse(strInput, out ret))
            {
                return ret;

            }
            else
            {
                try
                {
                    ret = Convert.ToInt32(input);
                    return ret;
                }
                catch
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Converts a double value to an integer.
        /// </summary>
        /// <param name="input">The double value to convert.</param>
        /// <returns>The converted integer value.</returns>
        public static int ToInt32(this double input)
        {

            int ret = 0;
            if (int.TryParse(input.ToSString(), out ret))
            {
                return ret;

            }
            else
            {
                try
                {
                    ret = Convert.ToInt32(input);
                    return ret;
                }
                catch
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Converts a decimal value to an integer.
        /// </summary>
        /// <param name="input">The decimal value to convert.</param>
        /// <returns>The converted integer value.</returns>
        public static int ToInt32(this decimal input)
        {

            int ret = 0;
            if (int.TryParse(input.ToSString(), out ret))
            {
                return ret;

            }
            else
            {
                try
                {
                    ret = Convert.ToInt32(input);
                    return ret;
                }
                catch
                {
                    return 0;
                }
            }

        }


        /// <summary>
        /// This method converts the input to a long. If the input is null or empty, it returns 0.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static long ToInt64(this object? input)
        {
            string strInput = input == null ? "" : input.ToString();
            long ret = 0;
            if (string.IsNullOrEmpty(strInput)) { return 0; }
            if (long.TryParse(strInput, out ret))
            {
                return ret;

            }
            else
            {
                try
                {
                    ret = Convert.ToInt64(strInput);
                    return ret;
                }
                catch
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// Converts an object to a long integer.
        /// </summary>
        /// <param name="input">The object to convert.</param>
        /// <returns>The long integer representation of the object.</returns>
        public static long ToLong(this object? input)
        {
            return ToInt64(input);
        }


        /// <summary>
        /// This method converts the string input to a boolean. If the input is null or empty, it returns false.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool ToBool(this string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return (input.ToLower() == "true" || input.ToLower().Trim() == "1");
            }
        }

        /// <summary>
        /// Converts an object to a boolean value.
        /// </summary>
        /// <param name="input">The object to convert.</param>
        /// <returns>True if the object is not null and can be converted to a boolean value, false otherwise.</returns>
        public static bool ToBool(this object? input)
        {
            if (input == null)
            {
                return false;
            }
            else
            {
                return ToBool(input.ToSString());
            }
        }

        /// <summary>
        /// Converts an object to a DateTime value.
        /// </summary>
        /// <param name="input">The object to convert.</param>
        /// <returns>The converted DateTime value. If the input is null, returns DateTime.MinValue.</returns>
        public static DateTime ToDateTime(this object? input)
        {
            if (input == null)
            {
                return DateTime.MinValue;
            }
            else
            {
                DateTime ret = DateTime.MinValue;
                DateTime.TryParse(input.ToString(), out ret);
                return ret;
            }
        }

        /// <summary>
        /// Converts an object to a 16-bit signed integer.
        /// </summary>
        /// <param name="input">The object to convert.</param>
        /// <returns>The converted 16-bit signed integer.</returns>
        public static short ToInt16(this object? input)
        {
            string strInput = input == null ? "" : input.ToString();
            short ret = 0;
            if (string.IsNullOrEmpty(strInput)) { return 0; }
            if (short.TryParse(strInput, out ret))
            {
                return ret;

            }
            else
            {
                try
                {
                    ret = Convert.ToInt16(strInput);
                    return ret;
                }
                catch
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Converts an object to a short (Int16) value.
        /// </summary>
        /// <param name="input">The object to convert.</param>
        /// <returns>The converted short value.</returns>
        public static short ToShort(this object? input)
        {
            return ToInt16(input);
        }

        /// <summary>
        /// Converts an object to a byte value.
        /// </summary>
        /// <param name="input">The object to convert.</param>
        /// <returns>The byte value of the object. Returns 0 if the object is null or empty, or if the conversion fails.</returns>
        public static byte ToByte(this object? input)
        {
            string strInput = input == null ? "" : input.ToString();
            byte ret = 0;
            if (string.IsNullOrEmpty(strInput)) { return 0; }
            if (byte.TryParse(strInput, out ret))
            {
                return ret;

            }
            else
            {
                try
                {
                    ret = Convert.ToByte(strInput);
                    return ret;
                }
                catch
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Converts an object to a float value.
        /// </summary>
        /// <param name="input">The object to convert.</param>
        /// <returns>The float value of the object, or 0 if the conversion fails.</returns>
        public static float ToFloat(this object? input)
        {
            string strInput = input == null ? "" : input.ToString();
            float ret = 0;
            if (string.IsNullOrEmpty(strInput)) { return 0; }
            if (float.TryParse(strInput, out ret))
            {
                return ret;

            }
            else
            {
                try
                {
                    ret = Convert.ToSingle(strInput);
                    return ret;
                }
                catch
                {
                    return 0;
                }
            }
        }


        /// <summary>
        /// Converts a string to a Guid.
        /// </summary>
        /// <param name="input">The string to convert.</param>
        /// <returns>The Guid representation of the input string, or Guid.Empty if the conversion fails.</returns>
        public static Guid ToGuid(this string input)
        {
            string strInput = input.ToSString();
            Guid ret = Guid.Empty;
            if (string.IsNullOrEmpty(strInput)) { return Guid.Empty; }
            if (Guid.TryParse(strInput, out ret))
            {
                return ret;
            }
            else
            {
                try
                {
                    ret = new Guid(strInput);
                    return ret;
                }
                catch
                {
                    return Guid.Empty;
                }
            }
        }



        /// <summary>
        /// Converts a string to an enum of type T.
        /// </summary>
        /// <typeparam name="T">The type of the enum.</typeparam>
        /// <param name="input">The string to convert.</param>
        /// <returns>The enum value of type T.</returns>
        public static T ToEnum<T>(this string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                return default(T);
            }
            else
            {
                return (T)Enum.Parse(typeof(T), input);
            }

        }

        /// <summary>
        /// Converts a string value to an enum of type TEnum.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="value">The string value to convert.</param>
        /// <returns>The enum value if the conversion is successful; otherwise, the default value of TEnum.</returns>
        public static TEnum ToEnumm<TEnum>(this string value, TEnum defaultValue = default) where TEnum : struct
        {
            if (string.IsNullOrWhiteSpace(value))
                return defaultValue;

            return Enum.TryParse(value, true, out TEnum result) ? result : defaultValue;

        }

        /// <summary>
        /// Converts an enum type to an array of string values.
        /// </summary>
        /// <param name="enumType">The enum type to convert.</param>
        /// <returns>An array of string values representing the enum values.</returns>
        public static string[] EnumToStringArray<TEnum>() where TEnum : struct
        {
            var enumType = typeof(TEnum);
            if (enumType.IsEnum)
                return Enum.GetNames(enumType);
            else return null;
        }


        /// <summary>
        /// Converts a byte array to a string using UTF-8 encoding.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <returns>The string representation of the byte array.</returns>
        public static string ToSString(this byte[] input)
        {

            if (input == null)
            {
                return "";
            }
            else
            {
                return System.Text.Encoding.UTF8.GetString(input);
            }
        }

        /// <summary>
        /// Converts a decimal value to a string representation using the specified format.
        /// </summary>
        /// <param name="input">The decimal value to convert.</param>
        /// <param name="format">The format string to use. Default is "#0.00#".</param>
        /// <returns>A string representation of the decimal value.</returns>
        public static string ToSString(this decimal input, string format = "#0.00#")
        {
            return input.ToString(format);
        }

        /// <summary>
        /// Converts a double value to a string representation using the specified format.
        /// </summary>
        /// <param name="input">The double value to convert.</param>
        /// <param name="format">The format string to use. Default is "#0.00#".</param>
        /// <returns>A string representation of the double value.</returns>
        public static string ToSString(this double input, string format = "#0.00#")
        {
            return input.ToString(format);
        }

        /// <summary>
        /// Converts a float value to a string representation using the specified format.
        /// </summary>
        /// <param name="input">The float value to convert.</param>
        /// <param name="format">The format string to use. Default is "#0.00#".</param>
        /// <returns>A string representation of the float value.</returns>
        public static string ToSString(this float input, string format = "#0.00#")
        {
            return input.ToString(format);
        }


        /// <summary>
        /// Extension method that converts a DateTime object to a string representation using the specified format.
        /// </summary>
        /// <param name="input">The DateTime object to convert.</param>
        /// <param name="format">The format string to use for the conversion. Default is "yyyy-MM-dd HH:mm:ss".</param>
        /// <returns>A string representation of the DateTime object.</returns>
        public static string ToSString(this DateTime input, string format = "yyyy-MM-dd HH:mm:ss")
        {
            return input.ToString(format);
        }

        /// <summary>
        /// Converts an integer to a string representation using the specified format.
        /// </summary>
        /// <param name="input">The integer to convert.</param>
        /// <param name="format">The format to use for the string representation. Default is "#0".</param>
        /// <returns>The string representation of the integer.</returns>
        public static string ToSString(this int input, string format = "#0")
        {
            return input.ToString(format);
        }

        /// <summary>
        /// Converts the input string to title case.
        /// </summary>
        /// <param name="input">The string to convert.</param>
        /// <returns>The input string converted to title case.</returns>
        public static string ToTitleCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            else
            {
                return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
            }
        }

        /// <summary>
        /// Converts a string to camel case format.
        /// </summary>
        /// <param name="input">The input string to convert.</param>
        /// <returns>The input string converted to camel case format.</returns>
        public static string ToCamelCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            else
            {
                string title = ToTitleCase(input);
                if (title.Length == 0) return "";
                if (title.Length == 1) return title.ToLower();

                {
                    string camelCase = char.ToLower(title[0]) + title.Substring(1);
                    return camelCase;
                }

            }
        }




        /// <summary>
        /// Converts an array of integers to an array of strings using the specified format.
        /// </summary>
        /// <param name="input">The array of integers to convert.</param>
        /// <param name="format">The format to use for converting each integer to a string.</param>
        /// <returns>An array of strings representing the converted integers.</returns>
        public static string[] ToStringArray(this int[] input, string format = "#0")
        {

            if (input == null)
            {
                return new string[0];
            }
            else
            {
                string[] ret = new string[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    ret[i] = input[i].ToSString(format);
                }
                return ret;
            }
        }

        /// <summary>
        /// Converts an array of decimal values to an array of strings using the specified format.
        /// </summary>
        /// <param name="input">The array of decimal values to convert.</param>
        /// <param name="format">The format to use for converting each decimal value to a string. Default is "#0.00#".</param>
        /// <returns>An array of strings representing the decimal values.</returns>
        public static string[] ToStringArray(this decimal[] input, string format = "#0.00#")
        {

            if (input == null)
            {
                return new string[0];
            }
            else
            {
                string[] ret = new string[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    ret[i] = input[i].ToSString(format);
                }
                return ret;
            }
        }

        /// <summary>
        /// Converts an array of DateTime objects to an array of strings using the specified format.
        /// </summary>
        /// <param name="input">The array of DateTime objects to convert.</param>
        /// <param name="format">The format to use when converting the DateTime objects to strings. Default is "yyyy-MM-dd HH:mm:ss".</param>
        /// <returns>An array of strings representing the DateTime objects in the specified format.</returns>
        public static string[] ToStringArray(this DateTime[] input, string format = "yyyy-MM-dd HH:mm:ss")
        {

            if (input == null)
            {
                return new string[0];
            }
            else
            {
                string[] ret = new string[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    ret[i] = input[i].ToSString(format);
                }
                return ret;
            }
        }

        /// <summary>
        /// Converts a DateOnly object to a string representation using the specified format.
        /// </summary>
        /// <param name="input">The DateOnly object to convert.</param>
        /// <param name="format">The format string to use for the conversion. Default is "yyyy-MM-dd".</param>
        /// <returns>A string representation of the DateOnly object.</returns>
        public static string ToSString(this DateOnly input, string format = "yyyy-MM-dd")
        {
            return input.ToString(format);
        }

        /// <summary>
        /// Converts a double array to a string array using the specified format.
        /// </summary>
        /// <param name="input">The double array to convert.</param>
        /// <param name="format">The format to use for converting each double value to a string.</param>
        /// <returns>A string array containing the converted values.</returns>
        public static string[] ToStringArray(this double[] input, string format)
        {

            if (input == null)
            {
                return new string[0];
            }
            else
            {
                string[] ret = new string[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    ret[i] = input[i].ToSString(format);
                }
                return ret;
            }
        }


        /// <summary>
        /// Removes the specified text from the input string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="remove">The text to remove.</param>
        /// <returns>The input string with the specified text removed.</returns>
        public static string RemoveText(this string input, string remove)
        {
            return input.Replace(remove, "");
        }

        /// <summary>
        /// Returns the leftmost characters of a string up to a specified length.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="length">The maximum length of the returned string.</param>
        /// <returns>The leftmost characters of the input string up to the specified length.</returns>
        public static string Left(this string input, int length)
        {
            if (input.Length <= length)
            {
                return input;
            }
            else
            {
                return input.Substring(0, length);
            }
        }

        /// <summary>
        /// Returns the rightmost characters of a string up to a specified length.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="length">The maximum number of characters to return.</param>
        /// <returns>The rightmost characters of the input string.</returns>
        public static string Right(this string input, int length)
        {
            if (input.Length <= length)
            {
                return input;
            }
            else
            {
                return input.Substring(input.Length - length, length);
            }
        }

        /// <summary>
        /// Converts a Stream object to a byte array.
        /// </summary>
        /// <param name="stream">The Stream object to convert.</param>
        /// <returns>The byte array representation of the Stream object.</returns>
        public static byte[] StreamToByteArray(this Stream stream)
        {

            if (stream == null)
            {
                return null;
            }
            else
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }



        /// <summary>
        /// Converts a byte array to a stream.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <returns>A stream containing the byte array data.</returns>
        public static Stream ToStream(this byte[] input)
        {
            if (input == null)
            {
                return null;
            }
            else
            {
                return new MemoryStream(input);
            }
        }


        /// <summary>
        /// Converts a Bitmap image to a Stream.
        /// </summary>
        /// <param name="input">The Bitmap image to convert.</param>
        /// <returns>A Stream containing the image data.</returns>
        public static Stream ToStream(this Bitmap input)
        {

            if (input == null)
            {
                return null;
            }
            else
            {
                return new MemoryStream(input.ToByteArray());
            }

        }

        /// <summary>
        /// Converts a Bitmap object to a byte array.
        /// </summary>
        /// <param name="input">The Bitmap object to convert.</param>
        /// <returns>A byte array representing the Bitmap object.</returns>
        public static byte[] ToByteArray(this Bitmap input)
        {
            if (input == null)
            {
                return null;
            }
            else
            {
                using (var stream = new MemoryStream())
                {
                    input.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
        }

        /// <summary>
        /// Converts a byte array to a Bitmap object.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <returns>The resulting Bitmap object, or null if the input is null.</returns>
        public static Bitmap ToBitmap(this byte[] input)
        {
            if (input == null)
            {
                return null;
            }
            else
            {
                using (var stream = new MemoryStream(input))
                {
                    return new Bitmap(stream);
                }
            }
        }

        /// <summary>
        /// Converts a Stream object to a Bitmap object.
        /// </summary>
        /// <param name="input">The Stream object to convert.</param>
        /// <returns>A Bitmap object representing the contents of the Stream, or null if the conversion fails.</returns>
        public static Bitmap ToBitmap(this Stream input)
        {
            if (input == null)
            {
                return null;
            }
            try
            {
                if (!input.CanRead || input.Length == 0)
                {
                    return null;
                }
                return new Bitmap(input);
            }
            catch (Exception)
            {
                return null;
            }
        }




    }
}
