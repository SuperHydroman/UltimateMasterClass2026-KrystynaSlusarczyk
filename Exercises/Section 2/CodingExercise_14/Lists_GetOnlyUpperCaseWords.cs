using System;

namespace Coding.Exercise
{
    public partial class Exercise
    {
        public List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            List<string> result = new();
            
            foreach (string word in words)
            {
                bool isOnlyUpperCase = word.Length > 0;
                
                foreach (char character in word)
                {
                    if (!char.IsUpper(character))
                    {
                        isOnlyUpperCase = false;
                        break;
                    }
                }
        
                if (isOnlyUpperCase && !result.Contains(word))
                    result.Add(word);
            }
        
            return result;
        }
    }
}