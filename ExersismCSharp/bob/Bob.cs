using System.Linq;

namespace ExersismCSharp.bob
{
    class Bob
    {
        public string Hey(string text)
        {
            var trimedText = text.Trim();

            if (IsShouting(trimedText))
            {
                return "Whoa, chill out!";
            }
            else if (IsQuestion(trimedText))
            {
                return "Sure.";
            }
            else if (string.IsNullOrEmpty(trimedText))
            {
                return "Fine. Be that way!";
            }
            return "Whatever.";
           
        }

        private bool IsShouting(string text)
        {
            return text.Any(c => char.IsLetter(c)) && text.Equals(text.ToUpper());
        }

        private bool IsQuestion(string text)
        {
            return text.EndsWith("?");
        }
    }
}
