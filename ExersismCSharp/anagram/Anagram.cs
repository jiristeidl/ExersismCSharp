using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        private bool IsAnagram(string originalWord, string potentialAnagram)
        {
            var originalCharArray = orignalWord.ToLower().ToCharArray();
            var anagramCharArray = potentialAnagram.ToLower().ToCharArray();

            if (originalCharArray.Length == anagramCharArray.Length)
            {
                var matchMatrix = new bool[originalCharArray.Length];
                for (int i = 0; i < originalCharArray.Length; i++)
                {
                    if (ContaisChar(anagramCharArray,originalCharArray[i]))
                    {
                        int repetitions = originalCharArray.Count(l => l.Equals(originalCharArray[i]));
                        if (repetitions > 1 && anagramCharArray.Count(c => c.Equals(originalCharArray[i])) == repetitions)
                        {
                            matchMatrix[i] = true;
                        }
                        else if (repetitions == 1)
                        {
                            matchMatrix[i] = true;
                        }
                    }
                }
                if (matchMatrix.All(v => v == true))
                {
                    return true;
                }
            }
            return false;
            throw new NotImplementedException();
        }
        private bool ContaisChar(char[] charArray, char letter)
        {
            return charArray.Contains(letter);
        }
        private bool ContainsMultipleRepetions(char[] charArray, char letter)
        {
            return charArray.Count(c => c.Equals(letter)) > 1;
        }
    }
}