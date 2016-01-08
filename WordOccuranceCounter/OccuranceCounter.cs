using CMTDeveloperRole.StringProcessor;
using System;
using System.ComponentModel.Composition;
using System.Linq;

namespace CMTDeveloperRole.WordOccuranceCounter
{
    [Export(typeof(IStringProcessor))]
    public class OccuranceCounter : IStringProcessor
    {
        static string[] WORDDELIMITER = new string[]{ " ", Environment.NewLine };
        public string Name
        {
            get { return "Word Occurance Counter"; }
        }

        public string Description
        {
            get { return "Count same word occurance in sentense"; }
        }

        public ProcessResult Process(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            var punctuations = input.Where(char.IsPunctuation).Distinct().ToArray();
            var words = input.Split(WORDDELIMITER, StringSplitOptions.RemoveEmptyEntries).Select(s=> s.Trim(punctuations).Trim());

            var result = new OccuranceResult();
            foreach(var word in words)
            {
                result.AddOccurance(word);
            }

            return result;
        }
    }
}
