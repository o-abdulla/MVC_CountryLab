using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryView
    {
        //props
        public Country DisplayCountry { get; set; }
        //constructor
        public CountryView(Country _country)
        {
            DisplayCountry = _country;
        }

        public void Display()
        {
            Console.Write($"Name: {DisplayCountry.Name}, Continent: {DisplayCountry.Continent} ");
            foreach (string c in DisplayCountry.Colors)
            {
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(c);
                Console.Write($"{c} ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
