namespace BgPersonGeneratorSpace
{
    internal class City
    {
        internal City(string name, int population)
        {
            this.Name = name;
            this.Population = population;
        }

        internal string Name { get; set; }

        internal int Population { get; set; }
    }
}
