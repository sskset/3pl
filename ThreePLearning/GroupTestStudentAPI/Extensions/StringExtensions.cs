using System;

namespace GroupTestStudentAPI.Extensions
{
    public static class StringExtensions
    {
        private static readonly char[] IllegalCharSet = { '{', '}', ',', ' ', '\t', '\r', '\n' };

        public static string[,] ToTimeMarksMatrix(this string rawString)
        {
            string[,] matrix = new string[6, 5];
            if (string.IsNullOrEmpty(rawString))
                return matrix;

            var textLines = rawString.Trim(IllegalCharSet).Split(Environment.NewLine);
            for (int i = 0; i < textLines.Length; i++)
            {
                var lineItems = textLines[i].Trim(IllegalCharSet).Split(',');
                for (int j = 0; j < lineItems.Length; j++)
                {
                    matrix[i, j] = lineItems[j].Trim('\'', '’', ' ');
                }
            }

            return matrix;
        }
    }
}
