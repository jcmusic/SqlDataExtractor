namespace YuStashSageX3_ETL.Helpers
{
    public static class StringHelper
    {
        public static string EscapeForSQL(string s)
        {
            if (s.Contains(SGL_QUOTE))
                s = s.Replace(SGL_QUOTE, ESCAPED_SGL_QUOTE);

            if (s.IndexOfAny(CHARACTERS_THAT_MUST_BE_QUOTED) > -1)
                s = SGL_QUOTE + s + SGL_QUOTE;

            return s;
        }
        public static string Escape(string s)
        {
            if (s.Contains(QUOTE))
                s = s.Replace(QUOTE, ESCAPED_QUOTE);

            if (s.IndexOfAny(CHARACTERS_THAT_MUST_BE_QUOTED) > -1)
                s = QUOTE + s + QUOTE;

            return s;
        }

        public static string Unescape(string s)
        {
            if (s.StartsWith(QUOTE) && s.EndsWith(QUOTE))
            {
                s = s.Substring(1, s.Length - 2);

                if (s.Contains(ESCAPED_QUOTE))
                    s = s.Replace(ESCAPED_QUOTE, QUOTE);
            }

            return s;
        }

        
        private const string QUOTE = "\"";
        private const string ESCAPED_QUOTE = "\"\"";
        private const string SGL_QUOTE = "\'";
        private const string ESCAPED_SGL_QUOTE = "\'\"";
        private static char[] CHARACTERS_THAT_MUST_BE_QUOTED = { ',', '"', '\n' };
    }
}
