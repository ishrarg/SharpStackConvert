using System;using System.Collections.Generic;using System.Data;using System.Linq;using System.Text;using System.Threading.Tasks;namespace SharpStackConvert{
    /// <summary>
    /// A static class that provides methods for converting DataTable objects to other data structures.
    /// </summary>
    public static class DataTableConverter    {


        /// <summary>
        /// Converts a two-dimensional string array into a DataTable.
        /// </summary>
        /// <param name="rows">The two-dimensional string array to convert.</param>
        /// <returns>A DataTable containing the data from the string array.</returns>
        public static DataTable ToTable(this string[][] rows)        {            if (rows == null) return null;            DataTable dt = new DataTable("Tbl");            if (rows.Length > 0)            {                for (int i = 0; i < rows[0].Length; i++)                {                    dt.Columns.Add("Col" + i.ToString());                }                foreach (string[] row in rows)                {                    dt.Rows.Add(row);                }            }            return dt;        }


        /// <summary>
        /// Converts a two-dimensional string array to a DataTable.
        /// </summary>
        /// <param name="rows">The two-dimensional string array to convert.</param>
        /// <returns>A DataTable containing the data from the two-dimensional string array.</returns>
        public static DataTable ToTable(this string[,] rows)        {            if (rows == null) return null;            DataTable dt = new DataTable("Tbl");            if (rows.Length > 0)            {                for (int i = 0; i < rows.GetLength(1); i++)                {                    dt.Columns.Add("Col" + i.ToString());                }                for (int i = 0; i < rows.GetLength(0); i++)                {                    string[] row = new string[rows.GetLength(1)];                    for (int j = 0; j < rows.GetLength(1); j++)                    {                        row[j] = rows[i, j];                    }                    dt.Rows.Add(row);                }            }            return dt;        }

        /// <summary>
        /// Converts an array of strings into a DataTable.
        /// </summary>
        /// <param name="rows">The array of strings to convert.</param>
        /// <returns>A DataTable containing the converted data.</returns>
        public static DataTable ToTable(this string[] rows)        {            if (rows == null) return null;            DataTable dt = new DataTable("Tbl");            if (rows.Length > 0)            {                for (int i = 0; i < rows.Length; i++)                {                    dt.Columns.Add("Col" + i.ToString());                }                dt.Rows.Add(rows);            }            return dt;        }

        /// <summary>
        /// Converts an array of strings into a DataTable with the specified table name.
        /// </summary>
        /// <param name="rows">The array of strings to convert.</param>
        /// <param name="tableName">The name of the DataTable.</param>
        /// <returns>The converted DataTable.</returns>
        public static DataTable ToTable(this string[] rows, string tableName)        {            if (rows == null) return null;            DataTable dt = new DataTable(tableName);            if (rows.Length > 0)            {                for (int i = 0; i < rows.Length; i++)                {                    dt.Columns.Add("Col" + i.ToString());                }                dt.Rows.Add(rows);            }            return dt;        }

        /// <summary>
        /// Converts a two-dimensional string array into a DataTable.
        /// </summary>
        /// <param name="rows">The two-dimensional string array to convert.</param>
        /// <param name="FirstRowIsHeader">A boolean value indicating whether the first row of the array should be treated as the header row of the DataTable.</param>
        /// <returns>A DataTable containing the data from the two-dimensional string array.</returns>
        public static DataTable ToTable(this string[,] rows, bool FirstRowIsHeader)        {            if (rows == null) return null;            DataTable dt = new DataTable("Tbl");            if (rows.Length > 0)            {                if (FirstRowIsHeader)                {                    for (int i = 0; i < rows.GetLength(1); i++)                    {                        dt.Columns.Add(rows[0, i]);                    }                    for (int i = 1; i < rows.GetLength(0); i++)                    {                        string[] row = new string[rows.GetLength(1)];                        for (int j = 0; j < rows.GetLength(1); j++)                        {                            row[j] = rows[i, j];                        }                        dt.Rows.Add(row);                    }                }                else                {                    for (int i = 0; i < rows.GetLength(1); i++)                    {                        dt.Columns.Add("Col" + i.ToString());                    }                    for (int i = 0; i < rows.GetLength(0); i++)                    {                        string[] row = new string[rows.GetLength(1)];                        for (int j = 0; j < rows.GetLength(1); j++)                        {                            row[j] = rows[i, j];                        }                        dt.Rows.Add(row);                    }                }            }            return dt;        }


        /// <summary>
        /// Converts a list of string arrays to a DataTable.
        /// </summary>
        /// <param name="rows">The list of string arrays to convert.</param>
        /// <param name="FirstRowIsHeader">Indicates whether the first row should be treated as the header row.</param>
        /// <param name="tableName">The name of the resulting DataTable.</param>
        /// <returns>The converted DataTable.</returns>
        public static DataTable ToTable(this List<string[]> rows, bool FirstRowIsHeader = true, string tableName = "Tbl")        {            if (rows == null) return null;            DataTable dt = new DataTable(tableName);            if (rows != null && rows.Count > 0)            {                if (FirstRowIsHeader)                {                    for (int i = 0; i < rows[0].Length; i++)                    {                        dt.Columns.Add(rows[0][i]);                    }                    for (int i = 1; i < rows.Count; i++)                    {                        string[] row = new string[rows[0].Length];                        for (int j = 0; j < rows[0].Length; j++)                        {                            row[j] = rows[i][j];                        }                        dt.Rows.Add(row);                    }                }                else                {                    for (int i = 0; i < rows[0].Length; i++)                    {                        dt.Columns.Add("Col" + i.ToString());                    }                    foreach (string[] row in rows)                    {                        dt.Rows.Add(row);                    }                }            }            return dt;        }    }}