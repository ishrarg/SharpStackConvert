using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace SharpStackConvert{
    /// <summary>
    /// A static class that provides methods for converting data into hash values.
    /// </summary>
    public static class HashConverter    {

        /// <summary>
        /// Converts a string to its MD5 hash representation.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <param name="encoding">The encoding to be used for converting the string to bytes.</param>
        /// <returns>The MD5 hash representation of the input string.</returns>
        public static string ToMD5(this string input, System.Text.Encoding encoding)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                using (var md5 = System.Security.Cryptography.MD5.Create())                {                    var hashedBytes = md5.ComputeHash(encoding.GetBytes(input));
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a string to its SHA1 hash value using the specified encoding.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <param name="encoding">The encoding to be used for converting the string to bytes.</param>
        /// <returns>The SHA1 hash value of the input string.</returns>
        public static string ToSHA1(this string input, System.Text.Encoding encoding)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                using (var sha1 = System.Security.Cryptography.SHA1.Create())                {                    var hashedBytes = sha1.ComputeHash(encoding.GetBytes(input));
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a string to its SHA256 hash value.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <param name="encoding">The encoding to be used for converting the string to bytes.</param>
        /// <returns>The SHA256 hash value of the input string.</returns>
        public static string ToSHA256(this string input, System.Text.Encoding encoding)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                using (var sha256 = System.Security.Cryptography.SHA256.Create())                {                    var hashedBytes = sha256.ComputeHash(encoding.GetBytes(input));                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a string to its SHA384 hash value using the specified encoding.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <param name="encoding">The encoding to be used for converting the string to bytes.</param>
        /// <returns>The SHA384 hash value of the input string.</returns>
        public static string ToSHA384(this string input, System.Text.Encoding encoding)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                using (var sha384 = System.Security.Cryptography.SHA384.Create())                {                    var hashedBytes = sha384.ComputeHash(encoding.GetBytes(input));                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a string to its SHA512 hash representation.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <param name="encoding">The encoding to be used for converting the string to bytes.</param>
        /// <returns>The SHA512 hash representation of the input string.</returns>
        public static string ToSHA512(this string input, System.Text.Encoding encoding)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                using (var sha512 = System.Security.Cryptography.SHA512.Create())                {                    var hashedBytes = sha512.ComputeHash(encoding.GetBytes(input));                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a byte array to a SHA1 hash string using the specified encoding.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <returns>The SHA1 hash string.</returns>
        public static string ToSHA1(this byte[] input, System.Text.Encoding encoding)        {            if (input == null)            {                return "";            }            else            {                using (var sha1 = System.Security.Cryptography.SHA1.Create())                {                    var hashedBytes = sha1.ComputeHash(input);
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a byte array to its SHA256 hash representation.
        /// </summary>
        /// <param name="input">The byte array to be hashed.</param>
        /// <param name="encoding">The encoding used to convert the byte array to a string.</param>
        /// <returns>The SHA256 hash representation of the byte array.</returns>
        public static string ToSHA256(this byte[] input, System.Text.Encoding encoding)        {            if (input == null)            {                return "";            }            else            {                using (var sha256 = System.Security.Cryptography.SHA256.Create())                {                    var hashedBytes = sha256.ComputeHash(input);                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a byte array to a SHA384 hash string using the specified encoding.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <returns>The SHA384 hash string.</returns>
        public static string ToSHA384(this byte[] input, System.Text.Encoding encoding)        {            if (input == null)            {                return "";            }            else            {                using (var sha384 = System.Security.Cryptography.SHA384.Create())                {                    var hashedBytes = sha384.ComputeHash(input);                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }


        /// <summary>
        /// Converts a byte array to a SHA512 hash string using the specified encoding.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <returns>The SHA512 hash string.</returns>
        public static string ToSHA512(this byte[] input, System.Text.Encoding encoding)        {            if (input == null)            {                return "";            }            else            {                using (var sha512 = System.Security.Cryptography.SHA512.Create())                {                    var hashedBytes = sha512.ComputeHash(input);                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a byte array to its MD5 hash representation.
        /// </summary>
        /// <param name="input">The byte array to be hashed.</param>
        /// <param name="encoding">The encoding used to convert the byte array to string.</param>
        /// <returns>The MD5 hash representation of the byte array as a string.</returns>
        public static string ToMD5(this byte[] input, System.Text.Encoding encoding)        {            if (input == null)            {                return "";            }            else            {                using (var md5 = System.Security.Cryptography.MD5.Create())                {                    var hashedBytes = md5.ComputeHash(input);
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a string to its MD5 hash value.
        /// </summary>
        /// <param name="input">The input string to be hashed.</param>
        /// <returns>The MD5 hash value of the input string.</returns>
        public static string ToMD5(this string input)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                using (var md5 = System.Security.Cryptography.MD5.Create())                {                    var hashedBytes = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a string to its SHA1 hash value.
        /// </summary>
        /// <param name="input">The input string to be hashed.</param>
        /// <returns>The SHA1 hash value of the input string.</returns>
        public static string ToSHA1(this string input)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                using (var sha1 = System.Security.Cryptography.SHA1.Create())                {                    var hashedBytes = sha1.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a string to its SHA256 hash value.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <returns>The SHA256 hash value of the input string.</returns>
        public static string ToSHA256(this string input)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                using (var sha256 = System.Security.Cryptography.SHA256.Create())                {                    var hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a string to its SHA384 hash value.
        /// </summary>
        /// <param name="input">The input string to be hashed.</param>
        /// <returns>The SHA384 hash value of the input string.</returns>
        public static string ToSHA384(this string input)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                using (var sha384 = System.Security.Cryptography.SHA384.Create())                {                    var hashedBytes = sha384.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a string to its SHA512 hash value.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <returns>The SHA512 hash value of the input string.</returns>
        public static string ToSHA512(this string input)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                using (var sha512 = System.Security.Cryptography.SHA512.Create())                {                    var hashedBytes = sha512.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a byte array to its SHA1 hash representation.
        /// </summary>
        /// <param name="input">The byte array to be hashed.</param>
        /// <returns>The SHA1 hash representation of the input byte array.</returns>
        public static string ToSHA1(this byte[] input)        {            if (input == null)            {                return "";            }            else            {                using (var sha1 = System.Security.Cryptography.SHA1.Create())                {                    var hashedBytes = sha1.ComputeHash(input);
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a byte array to its SHA256 hash representation.
        /// </summary>
        /// <param name="input">The byte array to be hashed.</param>
        /// <returns>The SHA256 hash representation of the input byte array.</returns>
        public static string ToSHA256(this byte[] input)        {            if (input == null)            {                return "";            }            else            {                using (var sha256 = System.Security.Cryptography.SHA256.Create())                {                    var hashedBytes = sha256.ComputeHash(input);                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a byte array to a SHA384 hash string.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <returns>The SHA384 hash string.</returns>
        public static string ToSHA384(this byte[] input)        {            if (input == null)            {                return "";            }            else            {                using (var sha384 = System.Security.Cryptography.SHA384.Create())                {                    var hashedBytes = sha384.ComputeHash(input);                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a byte array to a SHA512 hash string.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <returns>The SHA512 hash string.</returns>
        public static string ToSHA512(this byte[] input)        {            if (input == null)            {                return "";            }            else            {                using (var sha512 = System.Security.Cryptography.SHA512.Create())                {                    var hashedBytes = sha512.ComputeHash(input);                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }

        /// <summary>
        /// Converts a byte array to its MD5 hash value.
        /// </summary>
        /// <param name="input">The byte array to be hashed.</param>
        /// <returns>The MD5 hash value as a string.</returns>
        public static string ToMD5(this byte[] input)        {            if (input == null)            {                return "";            }            else            {                using (var md5 = System.Security.Cryptography.MD5.Create())                {                    var hashedBytes = md5.ComputeHash(input);
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();                }            }        }    }}