namespace DepdencyInjection
{
    public class SingletonProvider : IProvider
    {
        private static SampleService? sample = null;
        public SampleService GetSample()
        {
            //everytime use same object untill unless application restart
            if (sample == null)
                sample = new SampleService();
            return sample;
        }
    }
}
