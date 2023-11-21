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
        /// This method converts the input to a string. If the input is null, it returns an empty string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CString(this object? input)
        {
            if (input == null) return "";
            if (input is decimal)
                return ((decimal)input).ToString("#0.00#");
            if (input is double)
                return ((double)input).ToString("#0.00#");

            return input.ToString();
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
    }
}
