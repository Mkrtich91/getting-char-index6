﻿using System;

namespace GettingCharIndex
{
    public static class WhileMethods
    {
        public static int GetIndexOfChar(string? str, char value)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int index = 0;
            while (index < str.Length)
            {
                if (str[index] == value)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public static int GetIndexOfChar(string? str, char value, int startIndex, int count)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (startIndex < 0 || count < 0 || startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            int endIndex = startIndex + count - 1;
            int index = startIndex;

            while (index <= endIndex)
            {
                if (str[index] == value)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public static int GetLastIndexOfChar(string? str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int currentCharIndex = str.Length - 1;
            while (currentCharIndex >= 0)
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }

                currentCharIndex--;
            }

            return -1;
        }

        public static int GetLastIndexOfChar(string? str, char value, int startIndex, int count)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length");
            }

            int currentCharIndex = startIndex + count - 1;
            while (currentCharIndex >= startIndex)
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }

                currentCharIndex--;
            }

            return -1;
        }
    }
}
