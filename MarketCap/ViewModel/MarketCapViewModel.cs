using Microsoft.Maui.Graphics.Platform;
using System.Reflection;
using IImage = Microsoft.Maui.Graphics.IImage;

namespace MarketCap
{
    public class MarketCapViewModel
    {
        public List<MarketCapModel> MarketCapData { get; set; }

        public MarketCapViewModel()
        {
            MarketCapData = new List<MarketCapModel>(ReadCSV());
        }

        public static IEnumerable<MarketCapModel>   ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("MarketCap.Resources.Raw.MarketData.csv");

            if (inputStream == null)
            {
                throw new FileNotFoundException("CSV file not found.");
            }

            string line;
            List<string> lines = new();

            using StreamReader reader = new(inputStream);
            // Skip the header line
            reader.ReadLine();

            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            return lines.Select(line =>
            {
                string[] data = line.Split(',');

                return new MarketCapModel
                {
                    Size = Convert.ToDouble(data[1]),
                    Gdp = Convert.ToDouble(data[2]),
                    Company = Convert.ToInt32(data[3]),
                    Name = data[0],
                  ImageIcon = GetImage(data[4]) // Assuming the ImageIcon is the 5th column
                };
            });
        }

        private static IImage? GetImage(string resourcePath)
        {
            Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;
            using Stream? stream = assembly.GetManifestResourceStream("MarketCap.Resources.Images." + resourcePath + ".png");
            if (stream != null)
            {
                return PlatformImage.FromStream(stream);
            }
            return null;
        }
    }
}
