using CMTDeveloperRole.StringProcessor;
namespace CMTDeveloperRole.CharacterCounter
{
    public class CharCountResult : ProcessResult
    {
        private int _count;
        internal CharCountResult(int count)
        {
            _count = count;
        }
        public override string ToString()
        {
            return string.Format("Total char count: {0}", _count);
        }
    }
}