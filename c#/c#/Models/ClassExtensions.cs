namespace csharp.Models
{
    public static class StringExtensions
    {
        /// <param name="Palindrome"></param>

        public static bool IsPalindrome(this string Palindrome)
        {
            try
            {
                if (string.IsNullOrEmpty(Palindrome)) return false;

                string LowerPalindrome = Palindrome.ToLowerInvariant();
                var Reversed = ReverseString(LowerPalindrome);

                return Reversed == LowerPalindrome;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Niks ingevoerd: {ex.Message}");
                return false;
            }
        }
        /// <param name="input"></param>
        private static string ReverseString(string input)
        {
            var Chars = input.ToCharArray();
            Array.Reverse(Chars);
            return new string(Chars);
        }
    }
}