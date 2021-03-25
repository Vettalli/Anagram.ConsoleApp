using System.Collections.Generic;
using System.Linq;

namespace Anagram.Application
{
    public class AnagramAppllication : IAnagram
    {
        public string ReverseWord(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            var word = str.ToCharArray();
            string finalWord = "";
            int leftIndex = -1;
            int rightIndex = word.Length;

            for (int i = 0; i < word.Length / 2; i++)
            {

                if (char.IsLetter(word[i]) && i > leftIndex)
                {
                    leftIndex = i;

                    for (int j = rightIndex - 1; j > 0; j--)
                    {

                        if (char.IsLetter(word[j]) && j < rightIndex)
                        {
                            rightIndex = j;
                            break;
                        }
                    }

                    if (leftIndex > -1 && rightIndex < word.Length)
                    {
                        var temp = word[leftIndex];
                        word[leftIndex] = word[rightIndex];
                        word[rightIndex] = temp;
                    }
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                finalWord += word[i];
            }

            return finalWord;
        }

        public string Reverse(string str)
        {
            List<string> words = str.Split(' ').ToList();
            string wordsTemp = "";

            for (int i = 0; i < words.Count; i++)
            {
                var reversed = ReverseWord(words[i]);

                if (i < words.Count - 1)
                {
                    wordsTemp += reversed + " ";
                }
                else
                {
                    wordsTemp += reversed;
                }

            }
            string finalWord = string.Join(" ", wordsTemp);

            return finalWord;
        }
    }
}
