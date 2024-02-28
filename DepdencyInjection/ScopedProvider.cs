namespace DepdencyInjection
{
    public class ScopedProvider : IProvider
    {
        private SampleService? sample = null;
        public SampleService GetSample()
        {
            //everytime use same object for a particular scope or object
            sample ??= new SampleService();
            return sample;
        }
    }
}
