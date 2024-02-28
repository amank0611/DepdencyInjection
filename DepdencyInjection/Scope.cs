namespace DepdencyInjection
{
    public class Scope
    {
        public IProvider SingletonProvider { get; set; }
        public IProvider TransientProvider { get; set; }
        public IProvider ScopedProvider { get; set; }
        public Scope()
        {
            SingletonProvider = new SingletonProvider();
            TransientProvider = new TransientProvider();
            ScopedProvider = new ScopedProvider();
        }
    }
}
