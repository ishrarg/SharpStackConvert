using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStackConvert
{
    public static class CSVConverter
    {
        /// <summary>
        /// Converts a list of string arrays to a CSV format string.
        /// </summary>
        /// <param name="rows">The list of string arrays to convert.</param>
        /// <param name="Splitter">The delimiter to use for separating values (default is comma).</param>
        /// <returns>A string in CSV format.</returns>
        public static string ToCSVFormat(this List<string[]> rows, string Splitter = ",")
        {
            string returnValue = "";
            if (rows != null && rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {

                    for (int j = 0; j < rows[i].Length; j++)
                    {
                        if (j > 0)
                        {
                            returnValue += Splitter;
                        }
                        returnValue += rows[i][j].ToString();
                    }
                    returnValue += "\r\n";
                }
            }
            return returnValue;
        }



        /// <summary>
        /// Converts a two-dimensional string array to a CSV format string.
        /// </summary>
        /// <param name="rows">The two-dimensional string array to convert.</param>
        /// <param name="Splitter">The character used to separate values in the CSV format. Default is comma (,).</param>
        /// <returns>A string in CSV format.</returns>
        public static string ToCSVFormat(this string[,] rows, string Splitter = ",")
        {
            string returnValue = "";
            if (rows != null && rows.Length > 0)
            {
                for (int i = 0; i < rows.GetLength(0); i++)
                {

                    for (int j = 0; j < rows.GetLength(1); j++)
                    {
                        if (j > 0)
                        {
                            returnValue += Splitter;
                        }
                        returnValue += rows[i, j].ToString();
                    }
                    returnValue += "\r\n";
                }
            }
            return returnValue;
        }



        /// <summary>
        /// Converts a 2D array of strings to a CSV format string.
        /// </summary>
        /// <param name="rows">The 2D array of strings to convert.</param>
        /// <param name="Splitter">The character used to separate values in the CSV format. Default is ",".</param>
        /// <returns>A string in CSV format.</returns>
        public static string ToCSVFormat(this string[][] rows, string Splitter = ",")
        {
            string returnValue = "";
            if (rows != null && rows.Length > 0)
            {
                for (int i = 0; i < rows.Length; i++)
                {

                    for (int j = 0; j < rows[i].Length; j++)
                    {
                        if (j > 0)
                        {
                            returnValue += Splitter;
                        }
                        returnValue += rows[i][j].ToString();
                    }
                    returnValue += "\r\n";
                }
            }
            return returnValue;
        }


        //This is an extension method for the string class that splits a string into a list of lines.The method takes two parameters:1. "input" - the string to be split into lines.
        //2. "SkipEmptyLines" - a boolean flag indicating whether empty lines should be skipped or included in the resulting list.
        //The method first creates an empty list called "Lines" to store the lines. If the input string is null or empty, it returns the empty list.
        //If the input string is not null or empty, the method determines the splitting options based on the value of "SkipEmptyLines". If "SkipEmptyLines" is true, it sets the splitting option to "RemoveEmptyEntries", which removes any empty lines from the resulting array. If "SkipEmptyLines" is false, it sets the splitting option to "None", which includes empty lines in the resulting array.
        //The method then creates a character array containing the line separators "\r\n". It uses this array to split the input string into an array of lines using the "Split" method, passing in the splitting options.
        //Finally, the method adds all the lines from the resulting array to the "Lines" list using the "AddRange" method, and returns the list.

        /// <summary>
        /// Splits a string into a list of lines, with the option to skip empty lines.
        /// </summary>
        /// <param name="input">The input string to split.</param>
        /// <param name="SkipEmptyLines">A boolean indicating whether to skip empty lines or not.</param>
        /// <returns>A list of strings representing the lines of the input string.</returns>
        public static List<string> SplitLines(this string input, bool SkipEmptyLines)
        {
            List<string> Lines = new List<string>();
            if (string.IsNullOrEmpty(input))
            {
                return Lines;
            }
            else
            {
                StringSplitOptions opt = (SkipEmptyLines ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None);
                var splitters = "\r\n".ToCharArray();

                string[] arrLines = input.Split(splitters, opt);
                Lines.AddRange(arrLines);
                return Lines;
            }
        }



        /// <summary>
        /// Converts a CSV string to a DataTable.
        /// </summary>
        /// <param name="CSVData">The CSV string to convert.</param>
        /// <param name="TableName">The name of the DataTable.</param>
        /// <param name="FirstLineIsHeader">Indicates whether the first line of the CSV data is a header.</param>
        /// <param name="ColumnSplitter">The character used to split columns in the CSV data.</param>
        /// <returns>The converted DataTable.</returns>
        public static DataTable CSVToTable(this string CSVData, string TableName, bool FirstLineIsHeader = true, char ColumnSplitter = ',')
        {
            var lines = CSVData.SplitLines(true);
            if (lines.Count > 0)
            {
                string[] headers = lines[0].Split(ColumnSplitter);
                DataTable dt = new DataTable(TableName);
                if (FirstLineIsHeader)
                {
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dt.Columns.Add(headers[i]);
                    }

                    for (int i = 1; i < lines.Count; i++)
                    {
                        string[] row = lines[i].Split(ColumnSplitter);
                        dt.Rows.Add(row);
                    }
                }
                else
                {
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dt.Columns.Add("Col" + i.ToString());
                    }

                    foreach (string line in lines)
                    {
                        string[] row = line.Split(ColumnSplitter);
                        dt.Rows.Add(row);
                    }
                }
                return dt;
            }
            else
            {
                return new DataTable(TableName);
            }
        }

    }
}
