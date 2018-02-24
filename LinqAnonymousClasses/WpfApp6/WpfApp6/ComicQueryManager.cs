﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApp6
{
    class ComicQueryManager
    {
        public ObservableCollection<ComicQuery> AvailableQueries { get; private set; }
        public ObservableCollection<object> CurrentQueryResults { get; private set; }
        public string Title { get; set; }

        public ComicQueryManager()
        {
            UpdateAvailableQueries();
            CurrentQueryResults = new ObservableCollection<object>();
        }

        private void UpdateAvailableQueries()
        {
            AvailableQueries = new ObservableCollection<ComicQuery>
            {
                new ComicQuery("LINQ makes query simpler", "Query example",
                "Let`s demonstrate flexibility of LINQ",
                CreateImageFromAsserts("purple_250x250.jpg")),

                new ComicQuery("Expensive comics","Price over 500$",
                "Comics with price more then 500$" +
                "this thing let`s understand which comics buyer want most.",
                CreateImageFromAsserts("captain_amazing_250x250.jpg.jpg")),

                new ComicQuery("Universal Linq1","Change all returns by queries",
                "This code append string to the end of every string in array.",
                CreateImageFromAsserts("bluegray_250x250.jpg")),

                new ComicQuery("Universal Linq2", "Calculations in collections",
                "Linq provides extending methods to collections (and etc)"+
                "what implements interface IEnumerable<T>",
                CreateImageFromAsserts("purple_250x250.jpg")),

                new ComicQuery("Universal Linq3","Save all results to new sequence",
                "Sometimes Linq results are need to save separately",
                CreateImageFromAsserts("bluegray_250x250.jpg")),
            };
        }

        private BitmapImage CreateImageFromAsserts(string imageFilename)
        {
            try
            {
                Uri uri = new Uri(imageFilename, UriKind.RelativeOrAbsolute);
                return new BitmapImage(uri);
            }
            catch (System.IO.IOException)
            {

                return new BitmapImage();
            }
        }

        public void UpdateQueryResults(ComicQuery query)
        {
            Title = query.Title;
            switch (query.Title)
            {
                case "LINQ makes query simpler": LinqMakesQueriesEasy(); break;
                case "Expensive comics":ExpensiveComics();break;
                case "Universal Linq1":LinqIsVersatile1();break;
                case "Universal Linq2":LinqIsVersatile2();break;
                case "Universal Linq3":LinqIsVersatile3();break;
                default:
                    break;
            }
        }

        private void LinqIsVersatile3()
        {
            List<int> listOfNumbers = new List<int>();
            for (int i = 0; i <= 10000; i++)
            {
                listOfNumbers.Add(i);
            }
            var under50sorted =
                from number in listOfNumbers
                where number < 50
                orderby number descending
                select number;
            var firstFive = under50sorted.Take(6);

            List<int> shortList = firstFive.ToList();
            foreach (int n in shortList)
            {
                CurrentQueryResults.Add(CreateAnonymousListViewItem(n.ToString(), "bluegray_250x250.jpg"));
            }
        }

        private void LinqIsVersatile2()
        {
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
            {
                listOfNumbers.Add(random.Next(100));
            }

            CurrentQueryResults.Clear();
            CurrentQueryResults.Add(CreateAnonymousListViewItem(
                String.Format("There are {0} numbers", listOfNumbers.Count())));
            CurrentQueryResults.Add(CreateAnonymousListViewItem(String.Format("The smallest is {0}",listOfNumbers.Min())));
            CurrentQueryResults.Add(CreateAnonymousListViewItem(String.Format("The biggest is {0}", listOfNumbers.Max())));
            CurrentQueryResults.Add(CreateAnonymousListViewItem(String.Format("The sum is {0}", listOfNumbers.Sum())));
            CurrentQueryResults.Add(CreateAnonymousListViewItem(String.Format("The average is {0:F2}", listOfNumbers.Average())));
        }

        private void LinqIsVersatile1()
        {
            string[] sandwiches = {"ham and cheese","salami with mayo",
            "turkey and swiss","chicken cutlet" };
            var sandwichesOnRye = from sandwich in sandwiches
                                  select sandwich + " on rye";
            CurrentQueryResults.Clear();
            foreach (var sandwich in sandwichesOnRye)
            {
                CurrentQueryResults.Add(CreateAnonymousListViewItem(sandwich, "bluegray_250x250.jpg"));
            }
        }

        private object CreateAnonymousListViewItem(string title, string image="purple_250x250.jpg")
        {
            return new {
                Title = title,
                Image = CreateImageFromAsserts(image),
           };
        }

        public static IEnumerable<Comic> BuildCatalog()
        {
            return new List<Comic>
            {
               new Comic{ Name="Johnny America vs. the Pinko", Issue=6},
                new Comic{ Name="Rock and Roll (special edition)", Issue=19},
                new Comic{ Name="Woman`s Work", Issue=36},
                new Comic{ Name="Hippie Madness (with mistakes)", Issue=57},
                new Comic{ Name="Revenge of the New Wave Freak", Issue=68},
                new Comic{ Name="Black Monday", Issue=74},
                new Comic{ Name="Tribal Tattoo Madness", Issue=83},
                new Comic{ Name="The death of an Object",Issue=97},
            };
        }

        private static Dictionary<int,decimal> GetPrices()
        {
            return new Dictionary<int, decimal>
            {
                {6,3600M },
                {19,500M },
                {36,650M },
                {57, 13525M },
                {68, 250M },
                {74,75M },
                {83,25.75M },
                {97,32.25M },
            };
        }


        private void ExpensiveComics()
        {
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();

            var mostExpensive = from comic in comics
                                where values[comic.Issue] > 500
                                orderby values[comic.Issue] descending
                                select comic;
            CurrentQueryResults.Clear();
            foreach (Comic comic in mostExpensive)
            {
                CurrentQueryResults.Add(
                    new
                    {
                        Title=String.Format("{0} is worth {1:c} ",
                        comic.Name, values[comic.Issue]),
                        Image=CreateImageFromAsserts("captain_amazing_250x250.jpg.jpg"),
                    }
                    );
            }
        }

        private void LinqMakesQueriesEasy()
        {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            var result = from v in values
                         where v < 37
                         orderby v
                         select v;
            CurrentQueryResults.Clear();
            foreach (int i in result)
            {

                CurrentQueryResults.Add(
                    new {
                    Title = i.ToString(),
                    Image=CreateImageFromAsserts("purple_250x250.jpg"),

                });
            }
        }
    }
}
