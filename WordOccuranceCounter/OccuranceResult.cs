using CMTDeveloperRole.StringProcessor;
using System.Collections.Generic;
using System.Text;

namespace CMTDeveloperRole.WordOccuranceCounter
{
    public class OccuranceResult : ProcessResult
    {
        private Dictionary<string, int> _resultDict = new Dictionary<string,int>();

        internal void AddOccurance(string word)
        {
            if (word == null)
                return;

            if(_resultDict.ContainsKey(word))
                _resultDict[word]++;
            else
                _resultDict[word] = 1;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach( var kvp in _resultDict)
            {
                sb.AppendLine(string.Format("{0} - {1}", kvp.Key, kvp.Value));
            }
            return sb.ToString();
        }
    }
}
