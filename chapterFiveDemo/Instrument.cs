
namespace chapterFiveDemo
{
    public class Instrument
    {
        public string SerialNumber { get; }
        public double Price { get; private set; }
        public InstrumentSpec Spec { get; }
        public Instrument(string serialNumber, double price, InstrumentSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }
    }
}
