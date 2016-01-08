
namespace CMTDeveloperRole.StringProcessor
{
    public interface IStringProcessor
    {
        string Name { get; }
        string Description { get; }
        ProcessResult Process(string input);
    }
}
