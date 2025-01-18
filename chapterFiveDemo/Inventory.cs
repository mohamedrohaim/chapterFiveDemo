

using System.Diagnostics.Metrics;

namespace chapterFiveDemo
{
    public class Inventory
    {
        private List<Instrument> _instruments = new();

        public void AddInstrument(string serialNumber, double price, InstrumentSpec spec)
        {
            var instrument = new Instrument(serialNumber, price, spec);
            _instruments.Add(instrument);
        }

        public Instrument Get(string serialNumber)
        {
            return _instruments.Find(instrument => instrument.SerialNumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase));
        }

        public List<Instrument> Search(InstrumentSpec searchSpec)
        {
            var matchingInstruments = new List<Instrument>();

            foreach (var instrument in _instruments)
            {
                if (instrument.Spec.Matches(searchSpec))
                {
                    matchingInstruments.Add(instrument);
                }
            }

            return matchingInstruments;
        }
    }
}
