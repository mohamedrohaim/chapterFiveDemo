using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterFiveDemo
{
    public class GuitarSpec : InstrumentSpec
    {
        public int NumStrings { get; }
        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings)
        : base(builder, model, type, backWood, topWood)
        {
            NumStrings = numStrings;
        }
        public override bool Matches(InstrumentSpec otherSpec)
        {
            if (!base.Matches(otherSpec)) return false;

            if (otherSpec is GuitarSpec guitarSpec)
            {
                if (NumStrings != guitarSpec.NumStrings) return false;
            }

            return true;
        }
    }
}
