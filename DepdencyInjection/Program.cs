namespace DepdencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scope scope1 = new();
            Scope scope2 = new();

            SampleService sample1a = scope1.TransientProvider.GetSample();
            SampleService sample1b = scope1.TransientProvider.GetSample();
            SampleService sample2a = scope2.TransientProvider.GetSample();
            SampleService sample2b = scope2.TransientProvider.GetSample();

            Console.WriteLine($"Transient: {scope1.TransientProvider.GetSample().ID}");
            Console.WriteLine($"Transient: {scope1.TransientProvider.GetSample().ID}");
            Console.WriteLine($"Transient: {scope2.TransientProvider.GetSample().ID}");
            Console.WriteLine($"Transient: {scope2.TransientProvider.GetSample().ID}");
            Console.WriteLine("========================================");
            Console.WriteLine($"Singleton: {scope1.SingletonProvider.GetSample().ID}");
            Console.WriteLine($"Singleton: {scope1.SingletonProvider.GetSample().ID}");
            Console.WriteLine($"Singleton: {scope2.SingletonProvider.GetSample().ID}");
            Console.WriteLine($"Singleton: {scope2.SingletonProvider.GetSample().ID}");
            Console.WriteLine("========================================");
            Console.WriteLine($"Scoped: {scope1.ScopedProvider.GetSample().ID}");
            Console.WriteLine($"Scoped: {scope1.ScopedProvider.GetSample().ID}");
            Console.WriteLine($"Scoped: {scope2.ScopedProvider.GetSample().ID}");
            Console.WriteLine($"Scoped: {scope2.ScopedProvider.GetSample().ID}");
        }
    }
}
