using Microsoft.Maui.Graphics.Platform;
using System.Collections.ObjectModel;
using System.Reflection;

namespace MarketCap
{
    public class MarketCapViewModel
    {
        public List<MarketCapModel> MarketCapData { get; set; }
        public ObservableCollection<Brush> PaletteBrushes { get; set; }

        public MarketCapViewModel()
        {
            MarketCapData = new List<MarketCapModel>();
            MarketCapData.Add(new MarketCapModel { Size = 54000, Gdp = 194.5, Company = 4642, Name = "United States", ImageIcon = GetImage("us") });
            MarketCapData.Add(new MarketCapModel { Size = 10088, Gdp = 65.1, Company = 5346, Name = "China", ImageIcon = GetImage("china") });
            MarketCapData.Add(new MarketCapModel { Size = 6245, Gdp = 146.2, Company = 3865, Name = "Japan", ImageIcon = GetImage("japan") });
            MarketCapData.Add(new MarketCapModel { Size = 5522, Gdp = 140.1, Company = 5451, Name = "India", ImageIcon = GetImage("india") });
            MarketCapData.Add(new MarketCapModel { Size = 3894, Gdp = 84.9, Company = 457, Name = "France", ImageIcon = GetImage("france") });
            MarketCapData.Add(new MarketCapModel { Size = 3265, Gdp = 160.7, Company = 3534, Name = "Canada", ImageIcon = GetImage("canada") });
            MarketCapData.Add(new MarketCapModel { Size = 2875, Gdp = 347.0, Company = 269, Name = "Saudi Arabia", ImageIcon = GetImage("saudiarabia") });
            MarketCapData.Add(new MarketCapModel { Size = 2584, Gdp = 100, Company = 1646, Name = "United Kingdom", ImageIcon = GetImage("uk") });
            MarketCapData.Add(new MarketCapModel { Size = 2182, Gdp = 60, Company = 429, Name = "Germany", ImageIcon = GetImage("germany") });
            MarketCapData.Add(new MarketCapModel { Size = 2020, Gdp = 267.1, Company = 1627, Name = "Taiwan", ImageIcon = GetImage("taiwan") });
            MarketCapData.Add(new MarketCapModel { Size = 1884, Gdp = 133.5, Company = 2446, Name = "South Korea", ImageIcon = GetImage("south_korea") });
            MarketCapData.Add(new MarketCapModel { Size = 1743, Gdp = 390.1, Company = 546, Name = "Iran", ImageIcon = GetImage("iran") });
            MarketCapData.Add(new MarketCapModel { Size = 1723, Gdp = 129.3, Company = 1976, Name = "Australia", ImageIcon = GetImage("australia") });
            MarketCapData.Add(new MarketCapModel { Size = 1705, Gdp = 132.3, Company = 103, Name = "Netherlands", ImageIcon = GetImage("netherlands") });
            MarketCapData.Add(new MarketCapModel { Size = 1640, Gdp = 267.6, Company = 236, Name = "Switzerland", ImageIcon = GetImage("switzerland") });
            MarketCapData.Add(new MarketCapModel { Size = 1334, Gdp = 82.2, Company = 1472, Name = "Spain", ImageIcon = GetImage("spain") });
            MarketCapData.Add(new MarketCapModel { Size = 1230, Gdp = 348.3, Company = 237, Name = "South Africa", ImageIcon = GetImage("southafrica") });
            MarketCapData.Add(new MarketCapModel { Size = 1009, Gdp = 162, Company = 832, Name = "Sweden", ImageIcon = GetImage("sweden") });
            MarketCapData.Add(new MarketCapModel { Size = 873, Gdp = 172.3, Company = 153, Name = "United Arab Emirates", ImageIcon = GetImage("uae") });
            MarketCapData.Add(new MarketCapModel { Size = 863, Gdp = 68.4, Company = 361, Name = "Brazil", ImageIcon = GetImage("brazil") });
            MarketCapData.Add(new MarketCapModel { Size = 799, Gdp = 195, Company = 178, Name = "Denmark", ImageIcon = GetImage("denmark") });
            MarketCapData.Add(new MarketCapModel { Size = 778, Gdp = 46.3, Company = 903, Name = "Indonesia", ImageIcon = GetImage("indonesia") });
            MarketCapData.Add(new MarketCapModel { Size = 747, Gdp = 36.5, Company = 290, Name = "Italy", ImageIcon = GetImage("italy") });
            MarketCapData.Add(new MarketCapModel { Size = 715, Gdp = 108.8, Company = 117, Name = "Belgium", ImageIcon = GetImage("belgium") });
            MarketCapData.Add(new MarketCapModel { Size = 619, Gdp = 132.7, Company = 425, Name = "Singapore", ImageIcon = GetImage("singapore") });
            MarketCapData.Add(new MarketCapModel { Size = 604, Gdp = 122.0, Company = 810, Name = "Thailand", ImageIcon = GetImage("thailand") });
            MarketCapData.Add(new MarketCapModel { Size = 530, Gdp = 46.8, Company = 195, Name = "Russia", ImageIcon = GetImage("russia") });
            MarketCapData.Add(new MarketCapModel { Size = 454, Gdp = 31.0, Company = 133, Name = "Mexico", ImageIcon = GetImage("mexico") });
            MarketCapData.Add(new MarketCapModel { Size = 381, Gdp = 93.7, Company = 963, Name = "Malaysia", ImageIcon = GetImage("malaysia") });
            MarketCapData.Add(new MarketCapModel { Size = 377, Gdp = 71.7, Company = 340, Name = "Norway", ImageIcon = GetImage("norway") });
            MarketCapData.Add(new MarketCapModel { Size = 330, Gdp = 36.4, Company = 461, Name = "Turkey", ImageIcon = GetImage("turkey") });
            MarketCapData.Add(new MarketCapModel { Size = 285, Gdp = 94.8, Company = 400, Name = "Chile", ImageIcon = GetImage("chile") });
            MarketCapData.Add(new MarketCapModel { Size = 269, Gdp = 87.5, Company = 134, Name = "Finland", ImageIcon = GetImage("finland") });
            MarketCapData.Add(new MarketCapModel { Size = 269, Gdp = 51.4, Company = 518, Name = "Israel", ImageIcon = GetImage("israel") });
            MarketCapData.Add(new MarketCapModel { Size = 246, Gdp = 62.0, Company = 402, Name = "Vietnam", ImageIcon = GetImage("vietnam") });
        }
        private Microsoft.Maui.Graphics.IImage? GetImage(string resourcePath)
        {
            Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;
            using Stream? stream = assembly.GetManifestResourceStream("MarketCap.Resources.Images." + resourcePath + "1.png");
            if (stream != null)
            {
                return PlatformImage.FromStream(stream);
            }
            return null;
        }
    }
}
