using Microsoft.Maui.Graphics.Platform;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Dow30
{
    public class DowJonesViewModel
    {
        public List<DowJonesModel> DowData { get; set; }
        public ObservableCollection<Brush> PaletteBrushes { get; set; }

        public DowJonesViewModel()
        { 
            DowData = new List<DowJonesModel>();
            DowData.Add(new DowJonesModel { Size = 54000, Gdp = 194.5, Company = 4642, Name = "United States", ImageIcon = GetImage("us") });
            DowData.Add(new DowJonesModel { Size = 10088, Gdp = 65.1, Company = 5346, Name = "China", ImageIcon = GetImage("china") });
            DowData.Add(new DowJonesModel { Size = 6245, Gdp = 146.2, Company = 3865, Name = "Japan", ImageIcon = GetImage("japan") });
            DowData.Add(new DowJonesModel { Size = 5522, Gdp = 140.1, Company = 5451, Name = "India", ImageIcon = GetImage("india") });
            DowData.Add(new DowJonesModel { Size = 3894, Gdp = 84.9, Company = 457, Name = "France", ImageIcon = GetImage("france") });
            DowData.Add(new DowJonesModel { Size = 3265, Gdp = 160.7, Company = 3534, Name = "Canada", ImageIcon = GetImage("canada") });
            DowData.Add(new DowJonesModel { Size = 2875, Gdp = 347.0, Company = 269, Name = "Saudi Arabia", ImageIcon = GetImage("saudiarabia") });
            DowData.Add(new DowJonesModel { Size = 2584, Gdp = 100, Company = 1646, Name = "United Kingdom", ImageIcon = GetImage("uk") });
            DowData.Add(new DowJonesModel { Size = 2182, Gdp = 60, Company = 429, Name = "Germany", ImageIcon = GetImage("germany") });
            DowData.Add(new DowJonesModel { Size = 2020, Gdp = 267.1, Company = 1627, Name = "Taiwan", ImageIcon = GetImage("taiwan") });
            DowData.Add(new DowJonesModel { Size = 1884, Gdp = 133.5, Company = 2446, Name = "South Korea", ImageIcon = GetImage("south_korea") });
            DowData.Add(new DowJonesModel { Size = 1743, Gdp = 390.1, Company = 546, Name = "Iran", ImageIcon = GetImage("iran") });
            DowData.Add(new DowJonesModel { Size = 1723, Gdp = 129.3, Company = 1976, Name = "Australia", ImageIcon = GetImage("australia") });
            DowData.Add(new DowJonesModel { Size = 1705, Gdp = 132.3, Company = 103, Name = "Netherlands", ImageIcon = GetImage("netherlands") });
            DowData.Add(new DowJonesModel { Size = 1640, Gdp = 267.6, Company = 236, Name = "Switzerland", ImageIcon = GetImage("switzerland") });
            DowData.Add(new DowJonesModel { Size = 1334, Gdp = 82.2, Company = 1472, Name = "Spain", ImageIcon = GetImage("spain") });
            DowData.Add(new DowJonesModel { Size = 1230, Gdp = 348.3, Company = 237, Name = "South Africa", ImageIcon = GetImage("southafrica") });
            DowData.Add(new DowJonesModel { Size = 1009, Gdp = 162, Company = 832, Name = "Sweden", ImageIcon = GetImage("sweden") });
            DowData.Add(new DowJonesModel { Size = 873, Gdp = 172.3, Company = 153, Name = "United Arab Emirates", ImageIcon = GetImage("uae") });
            DowData.Add(new DowJonesModel { Size = 863, Gdp = 68.4, Company = 361, Name = "Brazil", ImageIcon = GetImage("brazil") });
            DowData.Add(new DowJonesModel { Size = 799, Gdp = 195, Company = 178, Name = "Denmark", ImageIcon = GetImage("denmark") });
            DowData.Add(new DowJonesModel { Size = 778, Gdp = 46.3, Company = 903, Name = "Indonesia", ImageIcon = GetImage("indonesia") });
            DowData.Add(new DowJonesModel { Size = 747, Gdp = 36.5, Company = 290, Name = "Italy", ImageIcon = GetImage("italy") });
            DowData.Add(new DowJonesModel { Size = 715, Gdp = 108.8, Company = 117, Name = "Belgium", ImageIcon = GetImage("belgium") });
            DowData.Add(new DowJonesModel { Size = 619, Gdp = 132.7, Company = 425, Name = "Singapore", ImageIcon = GetImage("singapore") });
            DowData.Add(new DowJonesModel { Size = 604, Gdp = 122.0, Company = 810, Name = "Thailand", ImageIcon = GetImage("thailand") });
            DowData.Add(new DowJonesModel { Size = 530, Gdp = 46.8, Company = 195, Name = "Russia", ImageIcon = GetImage("russia") });
            DowData.Add(new DowJonesModel { Size = 454, Gdp = 31.0, Company = 133, Name = "Mexico", ImageIcon = GetImage("mexico") });
            DowData.Add(new DowJonesModel { Size = 381, Gdp = 93.7, Company = 963, Name = "Malaysia", ImageIcon = GetImage("malaysia") });
            DowData.Add(new DowJonesModel { Size = 377, Gdp = 71.7, Company = 340, Name = "Norway", ImageIcon = GetImage("norway") });
            DowData.Add(new DowJonesModel { Size = 330, Gdp = 36.4, Company = 461, Name = "Turkey", ImageIcon = GetImage("turkey") });
            DowData.Add(new DowJonesModel { Size = 285, Gdp = 94.8, Company = 400, Name = "Chile", ImageIcon = GetImage("chile") });
            DowData.Add(new DowJonesModel { Size = 269, Gdp = 87.5, Company = 134, Name = "Finland", ImageIcon = GetImage("finland") });
            DowData.Add(new DowJonesModel { Size = 269, Gdp = 51.4, Company = 518, Name = "Israel", ImageIcon = GetImage("israel") });
            DowData.Add(new DowJonesModel { Size = 246, Gdp = 62.0, Company = 402, Name = "Vietnam", ImageIcon = GetImage("vietnam") });
        }
        private Microsoft.Maui.Graphics.IImage? GetImage(string resourcePath)
        {
            Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;
            using Stream? stream = assembly.GetManifestResourceStream("Dow30.Resources.Images." + resourcePath + "1.png");
            if (stream != null)
            {
                return PlatformImage.FromStream(stream);
            }
            return null;
        }
    }
}
