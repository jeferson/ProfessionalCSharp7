namespace NoDI
{
    public class GreetingService : IGreetingService
    {
        public int NumberOfCalls { get; private set; }

        public string Greet(string name)
        {
            NumberOfCalls++;
            return $"Hello, {name}. Number of calls: {NumberOfCalls}";
        }
    }
}
