﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\matt\Documents\src\Training\Collections\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            var filteredCountries = countries.Where(x => !x.Name.Contains(','));//.Take(20);
            var filteredCountries2 = from country in countries
                                     where !country.Name.Contains(',')
                                     select country;
            foreach (Country country in filteredCountries2)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }

            for (int i = 12; i < 14; i++)
            {
                Console.WriteLine(countries[i].Name);
            }
        }
    }
}
