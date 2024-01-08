using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace SharpStackConvert{
    /// <summary>
    /// A static class that provides methods for converting objects to and from JSON format.
    /// </summary>
    public static class JsonConverter    {
        /// <summary>
        /// Converts a JSON string to an object of type T.
        /// </summary>
        /// <typeparam name="T">The type of the object to convert to.</typeparam>
        /// <param name="json">The JSON string to convert.</param>
        /// <returns>The deserialized object of type T.</returns>
        public static T JsonToObject<T>(string json)        {            if (string.IsNullOrEmpty(json))            {                return default(T);            }            else            {                return System.Text.Json.JsonSerializer.Deserialize<T>(json);            }        }

        /// <summary>
        /// Converts an object to its JSON representation.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="obj">The object to convert.</param>
        /// <returns>The JSON representation of the object.</returns>
        public static string ObjectToJson<T>(T obj)        {            if (obj == null)            {                return "";            }            else            {                return System.Text.Json.JsonSerializer.Serialize<T>(obj);            }        }    }}