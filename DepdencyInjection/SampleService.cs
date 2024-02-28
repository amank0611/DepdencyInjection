namespace DepdencyInjection
{
    public class SampleService
    {
        public Guid ID { get; }
        public SampleService()
        {
            ID = Guid.NewGuid();
        }
    }
}
