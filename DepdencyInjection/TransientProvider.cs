namespace DepdencyInjection
{
    public class TransientProvider : IProvider
    {
        public SampleService GetSample()
        {
            //every time return new object
            return new SampleService();
        }
    }
}
