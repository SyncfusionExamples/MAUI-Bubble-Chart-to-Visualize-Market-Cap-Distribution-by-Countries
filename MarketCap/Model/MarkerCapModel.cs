using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCap 
{
    public class MarketCapModel
    {
        public string Name { get; set; }
        public Microsoft.Maui.Graphics.IImage? ImageIcon { get; set; }

        public double Company { get; set; }
        public double Size { get; set; }
        public double Gdp { get; set; }
        public MarketCapModel() { }

        public MarketCapModel(double value, double size, double weight, string name, Microsoft.Maui.Graphics.IImage imageIcon)
        {
            Name = name;
            ImageIcon = imageIcon;
            Company = value;
            Size = size;
            Gdp = weight;
        }
    }
}
