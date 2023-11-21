namespace SharpStackConvert
{
    public static class TypeConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this string input)
        {
            decimal ret = 0;
            if (string.IsNullOrEmpty(input)) { return 0; }
            decimal.TryParse(input, out ret);
            return ret;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double ToDouble(this string input)
        {
            double ret = 0;
            if (string.IsNullOrEmpty(input)) { return 0; }
            double.TryParse(input, out ret);
            return ret;
        }


        public static string CString(this object? input)
        {
            if (input == null) return "";
            if (input is decimal)
                return ((decimal)input).ToString("#0.00#");
            if (input is double)
                return ((double)input).ToString("#0.00#");

            return input.ToString();
        }
        public static int ToInt32(this string input)
        {
            int ret = 0;
            if (string.IsNullOrEmpty(input)) { return 0; }
            if (int.TryParse(input, out ret))
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
        public static long ToInt64(this string input)
        {
            long ret = 0;
            if (string.IsNullOrEmpty(input)) { return 0; }
            if (long.TryParse(input, out ret))
            {
                return ret;

            }
            else
            {
                try
                {
                    ret = Convert.ToInt64(input);
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
