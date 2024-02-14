using System;
using System.Linq;

public class Program
{
    public static void Main()
    {

    }

    public static bool Validate(Dictionary<char, char> openCloseChars, string input)
    {
        bool tempResult = false;

        List<char> currentOpenChars = new List<char>();

        for (int i = 0; i < input.Length; i++)
        {
            var current = input[i];
            bool isClosingChar = openCloseChars.ContainsValue(current);
            if (isClosingChar)
            {
                char lastOpenChar = currentOpenChars.LastOrDefault();
                // Get index of pair in dictionary
                var pair = openCloseChars.FirstOrDefault(x => x.Value == current);

                if (pair.Key == lastOpenChar)
                {
                    if(currentOpenChars.Count > 0) currentOpenChars.RemoveAt(currentOpenChars.Count -1); // We remove the last opening char from the list, since we found a matching closing char
                    tempResult = true;
                } // We found a matching closing char
                else
                {
                    tempResult = false;
                } // We found a non-matching closing char
            }
            else
            {
                currentOpenChars.Add(current); // We add the current opening char to the list, so we can check if the next char is a closing char
            }
        }

        if (currentOpenChars.Count > 0)
        { // If we have any opening chars left, then the input is invalid
            tempResult = false;
        }
        return tempResult;
    }
}	