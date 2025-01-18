

using System.Runtime.InteropServices;

namespace chapterFiveDemo
{
    public enum Builder { FENDER, MARTIN, GIBSON }
    public enum Type { ACOUSTIC, ELECTRIC }
    public enum Wood { MAHOGANY, MAPLE }
    public enum Style { A, F }

    public abstract class InstrumentSpec
    {
        public Builder Builder { get; }
        public string Model { get; }
        public Type Type { get; }
        public Wood BackWood { get; }
        public Wood TopWood { get; }

        public InstrumentSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }
        public virtual bool Matches(InstrumentSpec otherSpec)
        {
            if (otherSpec == null) return false;

            if (Builder != otherSpec.Builder) return false;
            if (!string.IsNullOrEmpty(Model) && !Model.Equals(otherSpec.Model, StringComparison.OrdinalIgnoreCase)) return false;
            if (Type != otherSpec.Type) return false;
            if (BackWood != otherSpec.BackWood) return false;
            if (TopWood != otherSpec.TopWood) return false;

            return true;
        }
    }

}
