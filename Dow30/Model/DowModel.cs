namespace Dow30
{
    public class DowJonesModel
    {
        public string Name { get; set; }
        public Microsoft.Maui.Graphics.IImage? ImageIcon { get; set; }

        public double Company { get; set; }
        public double Size { get; set; }
        public double Gdp { get; set; }
        public DowJonesModel() { }

        public DowJonesModel(double value, double size, double weight, string name, Microsoft.Maui.Graphics.IImage imageIcon)
        {
            Name = name;
            ImageIcon = imageIcon;
            Company = value;
            Size = size;
            Gdp = weight;
        }
    }
}
