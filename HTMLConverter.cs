using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace SharpStackConvert{
    /// <summary>
    /// This class provides methods for converting HTML to other formats.
    /// </summary>
    public static class HTMLConverter    {
        /// <summary>
        /// Extension method to escape special characters in a string for HTML encoding.
        /// </summary>
        /// <param name="input">The input string to be escaped.</param>
        /// <returns>The escaped string.</returns>
        public static string ToHTMLEscape(this string input)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                return System.Web.HttpUtility.HtmlEncode(input);            }        }

        /// <summary>
        /// Decodes HTML escape characters in a string.
        /// </summary>
        /// <param name="input">The input string to decode.</param>
        /// <returns>The decoded string.</returns>
        public static string FromHTMLEscape(this string input)        {            if (string.IsNullOrEmpty(input))            {                return "";            }            else            {                return System.Web.HttpUtility.HtmlDecode(input);            }        }    }}