using System;

namespace Coding.Exercise
{
    public partial class Exercise
    {
        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
            {
                new StringsTrimmingProcessor(),
                new StringsUppercaseProcessor()
            };
    
            List<string> result = words;
            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }

    public class StringsProcessor
    {
        public List<string> Process(List<string> words)
        {
            var result = new List<string>();
            foreach (string word in words)
            {
                result.Add(ProcessSingle(word));
            }

            return result;
        }

        protected virtual string ProcessSingle(string input) => input;
    }

    public class StringsTrimmingProcessor : StringsProcessor
    {
        protected override string ProcessSingle(string input)
            => input.Substring(0, input.Length / 2);
    }

    public class StringsUppercaseProcessor : StringsProcessor
    {
        protected override string ProcessSingle(string input) 
            => input.ToUpper();
    }
}