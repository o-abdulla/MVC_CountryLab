using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryController
    {
        public List<Country> CountryDb = new List<Country>()
        {
            new Country("USA", "North America", "Red", "White", "Blue"),
            new Country("Germany", "Europe", "Black", "Red", "Yellow"),
            new Country("Mexico", "North America", "Red", "White", "Green"),
            new Country("Germany", "Europe", "Black", "Red", "Yellow"),
            new Country("China", "Asia", "Red", "Yellow"),
            new Country("Brazil", "South America", "Green", "Yellow", "Blue"),
            new Country("Canada", "North America", "Red", "White"),
            new Country("Egypt", "Africa", "Red", "White", "Black"),
            new Country("India", "Asia", "DarkYellow", "White", "Green"),
            new Country("France", "Europe", "Red", "White", "Blue"),
            new Country("Antarctica", "Antarctica", "white"),
            new Country("Australia", "Oceania", "Blue", "Red", "White")
        };

        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
            
        }

        public void WelcomeAction()
        {
            bool runProgram = true;
            while (runProgram)
            {

                CountryListView listView = new CountryListView(CountryDb);
                listView.Display();

                //greeting and input
                Console.WriteLine("Hello welcome to the country app. Please select a country from the following list:");
                int choice = int.Parse(Console.ReadLine());

                Country c = CountryDb[choice];
                CountryAction(c);

                while (true)
                {
                    Console.WriteLine("\n\nWould you like to learn about another country? y/n");
                    string response = Console.ReadLine().Trim().ToLower();
                    if (response == "y" || response == "yes")
                    {
                        runProgram = true;
                        break;
                    }
                    else if (response == "n" ||  response == "no")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please choose either y or n");
                    }
                }
            }
        }
    }
}

