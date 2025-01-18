using chapterFiveDemo;
using Type = chapterFiveDemo.Type;

var inventory = new Inventory();

inventory.AddInstrument("12345", 1500.0, new GuitarSpec(Builder.FENDER, "Stratocaster", Type.ELECTRIC, Wood.MAPLE, Wood.MAPLE, 6));
inventory.AddInstrument("54321", 1200.0, new MandolinSpec(Builder.GIBSON, "A-style", Type.ACOUSTIC, Wood.MAHOGANY, Wood.MAHOGANY, Style.A));

var searchSpec = new GuitarSpec(Builder.FENDER, "Stratocaster", Type.ELECTRIC, Wood.MAPLE, Wood.MAPLE, 6);
var matchingInstruments = inventory.Search(searchSpec);

foreach (var instrument in matchingInstruments)
{
    Console.WriteLine($"Found: {instrument.Spec.Model} ({instrument.Price:C})");
}