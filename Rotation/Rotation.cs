using System;

namespace Rotation
{
    public static class Rotation
    {
        private static bool IsSubstring(string str, string substr)
        {
            return str.Contains(substr);
        }

        public static bool IsRotationString(string str, string substr)
        {
            if (str == null || substr == null)
            {
                throw new ArgumentNullException();
            }

            if (str.Length == substr.Length && str.Length > 0)
            {
                return IsSubstring($"{str}{str}", substr);
            }

            return false;
        }
    }
}