using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStackConvert
{
    public static class Base64Converter
    {

        /// <summary>
        /// Converts a string to its Base64 representation using the specified encoding.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <param name="encoding">The encoding to be used for converting the string to bytes.</param>
        /// <returns>The Base64 representation of the input string.</returns>
        public static string ToBase64(this string input, System.Text.Encoding encoding)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            else
            {
                return Convert.ToBase64String(encoding.GetBytes(input));
            }
        }

        /// <summary>
        /// Converts a base64 encoded string to its original form using the specified encoding.
        /// </summary>
        /// <param name="input">The base64 encoded string to convert.</param>
        /// <param name="encoding">The encoding to use for the conversion.</param>
        /// <returns>The original string represented by the base64 encoded input.</returns>
        public static string FromBase64(this string input, System.Text.Encoding encoding)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            else
            {
                return encoding.GetString(Convert.FromBase64String(input));
            }
        }


        //This is an extension method that converts a string to its Base64 representation.
        //The method first checks if the input string is null or empty. If it is, it returns an empty string.
        //If the input string is not null or empty, it converts the string to a byte array using UTF8 encoding. It then uses the Convert.ToBase64String method to convert the byte array to its Base64 representation.
        //Finally, it returns the Base64 representation of the input string.
        /// <summary>
        /// Converts a string to its Base64 representation.
        /// </summary>
        /// <param name="input">The input string to be converted.</param>
        /// <returns>The Base64 representation of the input string.</returns>
        public static string ToBase64(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            else
            {
                return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input));
            }
        }

        /// <summary>
        /// Converts a System.Drawing.Bitmap image to a base64 string.
        /// </summary>
        /// <param name="bitmap">The bitmap image to convert.</param>
        /// <returns>The base64 string representation of the image.</returns>
        public static string ImageToBase64(this System.Drawing.Bitmap bitmap)
        {
            if (bitmap != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] byteImage = ms.ToArray();
                return ToBase64(byteImage);
            }
            else return "";
        }


        /// <summary>
        /// Converts a base64 encoded string to a Bitmap object.
        /// </summary>
        /// <param name="input">The base64 encoded string.</param>
        /// <returns>The Bitmap object.</returns>
        public static Bitmap FromBase64ToBitmap(this string input)
        {

            byte[] byteImage = FromBase64ToByteArray(input);
            if (byteImage != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage);
                Bitmap bitmap = new Bitmap(ms);
                return bitmap;
            }
            else return null;
        }



        //This is an extension method for the string class that converts a base64 encoded string to its original UTF-8 encoded string representation.
        //The method first checks if the input string is null or empty. If it is, it returns an empty string.
        //If the input string is not null or empty, it uses the Convert.FromBase64String method to convert the base64 encoded string to a byte array. It then uses the System.Text.Encoding.UTF8.GetString method to convert the byte array to its original UTF-8 encoded string representation.
        //Finally, it returns the UTF-8 encoded string.

        /// <summary>
        /// Converts a base64 encoded string to its original UTF8 string representation.
        /// </summary>
        /// <param name="input">The base64 encoded string to convert.</param>
        /// <returns>The original UTF8 string representation of the base64 encoded string.</returns>
        public static string FromBase64(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            else
            {
                return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
            }
        }

        /// <summary>
        /// Converts a byte array to a Base64 string.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <returns>The Base64 string representation of the byte array.</returns>
        public static string ToBase64(this byte[] input)
        {
            if (input == null)
            {
                return "";
            }
            else
            {
                return Convert.ToBase64String(input);
            }
        }

        /// <summary>
        /// Converts a base64 encoded string to a byte array.
        /// </summary>
        /// <param name="input">The base64 encoded string to convert.</param>
        /// <returns>The byte array representation of the base64 encoded string.</returns>
        public static byte[] FromBase64ToByteArray(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new byte[0];
            }
            else
            {
                return Convert.FromBase64String(input);
            }
        }


        /// <summary>
        /// Converts a base64 encoded string to a byte array using the specified encoding.
        /// </summary>
        /// <param name="input">The base64 encoded string to convert.</param>
        /// <param name="encoding">The encoding to use for the conversion.</param>
        /// <returns>A byte array representing the decoded base64 string.</returns>
        public static byte[] FromBase64ToByteArray(this string input, System.Text.Encoding encoding)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new byte[0];
            }
            else
            {
                return Convert.FromBase64String(input);
            }
        }

        //ImageToBase64


    }
}
