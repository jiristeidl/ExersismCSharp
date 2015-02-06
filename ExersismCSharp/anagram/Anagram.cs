using System.Collections.Generic;
using System.Linq;

namespace ExersismCSharp.anagram
{
    internal class Anagram
    {
        private string orignalWord;

        public Anagram(string originalWord)
        {
            this.orignalWord = originalWord;
        }

        internal string[] Match(string[] anagramCandidates)
        {
            var temporaryResults = new List<string>();
            foreach (var potentialAnagram in anagramCandidates)
            {
                if (IsAnagram(orignalWord, potentialAnagram) && !potentialAnagram.ToLower().Equals(orignalWord.ToLower()))
                {
                    temporaryResults.Add(potentialAnagram);
                }
            }

            return temporaryResults.ToArray();
        }

        private bool ContainsMultipleRepetions(char[] charArray, char letter)
        {
            return charArray.Count(c => c.Equals(letter)) > 1;
        }

        private bool ContaisChar(char[] charArray, char letter)
        {
            return charArray.Contains(letter);
        }

        private bool IsAnagram(string originalWord, string potentialAnagram)
        {
            var originalCharArray = orignalWord.ToLower().ToCharArray();
            var potentialAnagramCharArray = potentialAnagram.ToLower().ToCharArray();

            if (originalCharArray.Length == potentialAnagramCharArray.Length)
            {
                var matchMatrix = new bool[originalCharArray.Length];

                for (int i = 0; i < originalCharArray.Length; i++)
                {
                    if (ContaisChar(potentialAnagramCharArray, originalCharArray[i]))
                    {
                        matchMatrix[i] = isMatch(originalCharArray, potentialAnagramCharArray, originalCharArray[i]);
                    }
                }
                if (matchMatrix.All(v => v == true))
                {
                    return true;
                }
            }
            return false;
        }

        private bool isMatch(char[] originalCharArray, char[] potentialAnagramCharArray, char matchedChar)
        {
            int CharRepetitions = originalCharArray.Count(l => l.Equals(matchedChar));
            if (CharRepetitions > 1 && potentialAnagramCharArray.Count(c => c.Equals(matchedChar)) == CharRepetitions)
            {
                return true;
            }
            else if (CharRepetitions == 1)
            {
                return true;
            }
            return false;
        }
    }
}