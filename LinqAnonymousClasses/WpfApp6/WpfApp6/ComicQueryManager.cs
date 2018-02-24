using System;
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
                default:
                    break;
            }
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
