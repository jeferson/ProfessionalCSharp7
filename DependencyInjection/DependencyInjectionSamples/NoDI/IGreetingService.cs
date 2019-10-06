namespace NoDI
{
    public interface IGreetingService
    {
        int NumberOfCalls { get; }

        string Greet(string name);
    }
}
