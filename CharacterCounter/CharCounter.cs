using CMTDeveloperRole.StringProcessor;
using System.ComponentModel.Composition;

namespace CMTDeveloperRole.CharacterCounter
{
    [Export(typeof(IStringProcessor))]
    public class CharCounter : IStringProcessor
    {
        public string Name
        {
            get { return "Character Counter"; }
        }

        public string Description
        {
            get { return "Count number of chars in sentense"; }
        }

        public ProcessResult Process(string input)
        {
            if (string.IsNullOrEmpty(input))
                return new CharCountResult(0);

            return new CharCountResult(input.Length);
        }
    }
}
