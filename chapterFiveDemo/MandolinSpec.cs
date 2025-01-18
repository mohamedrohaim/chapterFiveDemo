

namespace chapterFiveDemo
{
    public class MandolinSpec : InstrumentSpec
    {
        public Style Style { get; }
        public MandolinSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, Style style)
            : base(builder, model, type, backWood, topWood)
        {
            Style = style;
        }

        public override bool Matches(InstrumentSpec otherSpec)
        {
            if (!base.Matches(otherSpec)) return false;

            if (otherSpec is MandolinSpec mandolinSpec)
            {
                if (Style != mandolinSpec.Style) return false;
            }

            return true;
        }
    }
}
