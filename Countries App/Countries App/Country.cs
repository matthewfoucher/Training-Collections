using System;

namespace Collections
{
    class Country
    {
        public string Name;
        public string Code;
        public string Region;
        public int Population;

        public Country(string name, string code, string region, int population)
        {
            Name = name;
            Code = code;
            Region = region;
            Population = population;
        }
    }
}
