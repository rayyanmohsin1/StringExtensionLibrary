namespace StringExtensionLibrary
{
    public static class StringExtensions
    {
        public static bool StartsWithUpperCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            char firstChar = input[0];
            return char.IsUpper(firstChar);
        }
    }
}
