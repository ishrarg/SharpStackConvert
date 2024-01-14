using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SharpStackConvert
{
    /// <summary>
    /// A static class that provides methods for converting DataTable objects to other data structures.
    /// </summary>
    public static class DataTableConverter
    {


        /// <summary>
        /// Converts a two-dimensional string array into a DataTable.
        /// </summary>
        /// <param name="rows">The two-dimensional string array to convert.</param>
        /// <returns>A DataTable containing the data from the string array.</returns>
        public static DataTable ToTable(this string[][] rows)
        {
            if (rows == null) return null;
            DataTable dt = new DataTable("Tbl");

            if (rows.Length > 0)
            {
                for (int i = 0; i < rows[0].Length; i++)
                {
                    dt.Columns.Add("Col" + i.ToString());
                }

                foreach (string[] row in rows)
                {
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }


        /// <summary>
        /// Converts a two-dimensional string array to a DataTable.
        /// </summary>
        /// <param name="rows">The two-dimensional string array to convert.</param>
        /// <returns>A DataTable containing the data from the two-dimensional string array.</returns>
        public static DataTable ToTable(this string[,] rows)
        {
            if (rows == null) return null;
            DataTable dt = new DataTable("Tbl");

            if (rows.Length > 0)
            {
                for (int i = 0; i < rows.GetLength(1); i++)
                {
                    dt.Columns.Add("Col" + i.ToString());
                }

                for (int i = 0; i < rows.GetLength(0); i++)
                {
                    string[] row = new string[rows.GetLength(1)];
                    for (int j = 0; j < rows.GetLength(1); j++)
                    {
                        row[j] = rows[i, j];
                    }
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }

        /// <summary>
        /// Converts an array of strings into a DataTable.
        /// </summary>
        /// <param name="rows">The array of strings to convert.</param>
        /// <returns>A DataTable containing the converted data.</returns>
        public static DataTable ToTable(this string[] rows)
        {
            if (rows == null) return null;
            DataTable dt = new DataTable("Tbl");

            if (rows.Length > 0)
            {
                for (int i = 0; i < rows.Length; i++)
                {
                    dt.Columns.Add("Col" + i.ToString());
                }

                dt.Rows.Add(rows);
            }
            return dt;
        }

        /// <summary>
        /// Converts an array of strings into a DataTable with the specified table name.
        /// </summary>
        /// <param name="rows">The array of strings to convert.</param>
        /// <param name="tableName">The name of the DataTable.</param>
        /// <returns>The converted DataTable.</returns>
        public static DataTable ToTable(this string[] rows, string tableName)
        {
            if (rows == null) return null;
            DataTable dt = new DataTable(tableName);

            if (rows.Length > 0)
            {
                for (int i = 0; i < rows.Length; i++)
                {
                    dt.Columns.Add("Col" + i.ToString());
                }

                dt.Rows.Add(rows);
            }
            return dt;
        }

        /// <summary>
        /// Converts a two-dimensional string array into a DataTable.
        /// </summary>
        /// <param name="rows">The two-dimensional string array to convert.</param>
        /// <param name="FirstRowIsHeader">A boolean value indicating whether the first row of the array should be treated as the header row of the DataTable.</param>
        /// <returns>A DataTable containing the data from the two-dimensional string array.</returns>
        public static DataTable ToTable(this string[,] rows, bool FirstRowIsHeader)
        {
            if (rows == null) return null;
            DataTable dt = new DataTable("Tbl");

            if (rows.Length > 0)
            {
                if (FirstRowIsHeader)
                {
                    for (int i = 0; i < rows.GetLength(1); i++)
                    {
                        dt.Columns.Add(rows[0, i]);
                    }

                    for (int i = 1; i < rows.GetLength(0); i++)
                    {
                        string[] row = new string[rows.GetLength(1)];
                        for (int j = 0; j < rows.GetLength(1); j++)
                        {
                            row[j] = rows[i, j];
                        }
                        dt.Rows.Add(row);
                    }
                }
                else
                {
                    for (int i = 0; i < rows.GetLength(1); i++)
                    {
                        dt.Columns.Add("Col" + i.ToString());
                    }

                    for (int i = 0; i < rows.GetLength(0); i++)
                    {
                        string[] row = new string[rows.GetLength(1)];
                        for (int j = 0; j < rows.GetLength(1); j++)
                        {
                            row[j] = rows[i, j];
                        }
                        dt.Rows.Add(row);
                    }
                }
            }
            return dt;

        }


        /// <summary>
        /// Converts a list of string arrays to a DataTable.
        /// </summary>
        /// <param name="rows">The list of string arrays to convert.</param>
        /// <param name="FirstRowIsHeader">Indicates whether the first row should be treated as the header row.</param>
        /// <param name="tableName">The name of the resulting DataTable.</param>
        /// <returns>The converted DataTable.</returns>
        public static DataTable ToTable(this List<string[]> rows, bool FirstRowIsHeader = true, string tableName = "Tbl")
        {
            if (rows == null) return null;
            DataTable dt = new DataTable(tableName);

            if (rows != null && rows.Count > 0)
            {
                if (FirstRowIsHeader)
                {
                    for (int i = 0; i < rows[0].Length; i++)
                    {
                        dt.Columns.Add(rows[0][i]);
                    }

                    for (int i = 1; i < rows.Count; i++)
                    {
                        string[] row = new string[rows[0].Length];
                        for (int j = 0; j < rows[0].Length; j++)
                        {
                            row[j] = rows[i][j];
                        }
                        dt.Rows.Add(row);
                    }
                }
                else
                {
                    for (int i = 0; i < rows[0].Length; i++)
                    {
                        dt.Columns.Add("Col" + i.ToString());
                    }

                    foreach (string[] row in rows)
                    {
                        dt.Rows.Add(row);
                    }
                }
            }
            return dt;
        }


        /// <summary>
        /// Converts a DataTable to an HTML table.
        /// </summary>
        /// <param name="tbl">The DataTable to convert.</param>
        /// <returns>The HTML representation of the DataTable as a table.</returns>
        public static string ToHTMLTable(this DataTable tbl)
        {
            string tableTagStyle = "border: solid 1px Silver; font-size: x-small;";
            string tableBorder = "1px";
            StringBuilder sb = new StringBuilder();
            int cellPadding = 5;
            int cellSpacing = 0;
            string headerTextAlign = "left";
            string headerTextVAlign = "top";
            string tdAlign = "left";
            string tdVAlign = "top";

            sb.Append($"<table border='{tableBorder}' cellpadding='{cellPadding}' cellspacing='{cellSpacing}' ");

            sb.Append($"style='{tableTagStyle}'>");


            sb.Append("<tr align='left' valign='top'>");
            foreach (DataColumn col in tbl.Columns)
            {
                sb.Append($"<td align='{headerTextAlign}' valign='{headerTextVAlign}'><b>");
                sb.Append(col.ColumnName);
                sb.Append("</b></td>");
            }
            sb.Append("</tr>");


            foreach (DataRow row in tbl.Rows)
            {
                sb.Append($"<tr align='{tdAlign}' valign='{tdVAlign}'>");
                foreach (DataColumn col in tbl.Columns)
                {
                    sb.Append($"<td align='{tdAlign}' valign='{tdVAlign}'>");
                    sb.Append(row[col.ColumnName].ToSString());
                    sb.Append("</td>");
                }
                sb.Append("</tr>");
            }

            sb.Append("</table>");
            return sb.ToString();
        }




        /// <summary>
        /// Converts a DataTable to a Dictionary that contains key-value pairs from the DataTable based on the specified key and value columns.
        /// </summary>
        /// <param name="dt">The DataTable to convert.</param>
        /// <param name="keyColumn">The name of the key column.</param>
        /// <param name="valueColumn">The name of the value column.</param>
        /// <returns>A Dictionary with key-value pairs from the DataTable.</returns>
        public static Dictionary<string, string> DataTableToDict(this DataTable dt, string keyColumn, string valueColumn)
        {
            if (dt is null) return null;
            if (dt.Columns.IndexOf(keyColumn) < 0) return null;
            if (dt.Columns.IndexOf(valueColumn) < 0) return null;


            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (DataRow row in dt.Rows)
            {
                if (dict.ContainsKey(row[keyColumn].ToString()))
                    continue;

                dict.Add(row[keyColumn].ToString(), row[valueColumn].ToString());
            }
            return dict;
        }

        /// <summary>
        /// Converts a dictionary to a DataTable.
        /// </summary>
        /// <param name="dict">The dictionary to convert.</param>
        /// <param name="keyColumn">The name of the key column in the DataTable.</param>
        /// <param name="valueColumn">The name of the value column in the DataTable.</param>
        /// <param name="tableName">The name of the DataTable.</param>
        /// <returns>The converted DataTable.</returns>
        public static DataTable DictionaryToDatatable(this Dictionary<string, string> dict, string keyColumn, string valueColumn, string tableName = "Tbl")
        {

            if (dict is null) return null;
            if (dict.Count == 0) return null;

            DataTable dt = new DataTable(tableName);
            dt.Columns.Add(keyColumn);
            dt.Columns.Add(valueColumn);

            foreach (KeyValuePair<string, string> kvp in dict)
            {
                dt.Rows.Add(kvp.Key, kvp.Value);
            }
            return dt;
        }




        /// <summary>
        /// Converts a DataTable to XML string.
        /// </summary>
        /// <param name="tbl">The DataTable to convert.</param>
        /// <returns>The XML string representation of the DataTable.</returns>
        public static string DataTableToXML(this DataTable tbl)
        {

            if (tbl is null) return null;
            if (tbl.Rows.Count == 0) return null;

            System.IO.StringWriter writer = new System.IO.StringWriter();
            tbl.WriteXml(writer, XmlWriteMode.WriteSchema, false);
            return writer.ToString();
        }

        /// <summary>
        /// Converts an XML string to a DataTable.
        /// </summary>
        /// <param name="xml">The XML string to convert.</param>
        /// <returns>The converted DataTable.</returns>
        public static DataTable XMLToDataTable(this string xml)
        {
            if (xml is null) return null;
            if (xml.Length == 0) return null;

            System.IO.StringReader reader = new System.IO.StringReader(xml);
            DataTable dt = new DataTable();
            dt.ReadXml(reader);
            return dt;
        }

        /// <summary>
        /// Converts a DataTable to a JSON string.
        /// </summary>
        /// <param name="tbl">The DataTable to convert.</param>
        /// <returns>A JSON string representing the DataTable.</returns>
        public static string DataTableToJSON(this DataTable tbl)
        {
            if (tbl is null) return "";
            StringBuilder jsonResult = new StringBuilder();

            jsonResult.Append("[\n");

            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                jsonResult.Append("{");

                for (int j = 0; j < tbl.Columns.Count; j++)
                {
                    jsonResult.Append($"\"{tbl.Columns[j].ColumnName}\": \"{tbl.Rows[i][j]}\"");

                    if (j < tbl.Columns.Count - 1)
                        jsonResult.Append(", ");
                }

                jsonResult.Append("}");

                if (i < tbl.Rows.Count - 1)
                    jsonResult.Append(", ");

                jsonResult.Append("\n");
            }

            jsonResult.Append("]");

            return jsonResult.ToString();

        }





    }
}