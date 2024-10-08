using Syncfusion.Maui.Charts; 

namespace MarketCap
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnLabelCreated(object sender, Syncfusion.Maui.Charts.ChartAxisLabelEventArgs e)
        {
            // Check if the value is in thousands
            if (e.Position is double value && value >= 1000)
            {
                // Divide by 1000 and append "k"
                e.Label = (value / 1000).ToString("0") + "K";
            }
        }
    }

    public class BubbleExt : BubbleSeries
    {
        protected override ChartSegment CreateSegment()
        {
            return new BubbleSegmentExt();
        }

    }
    public class BubbleSegmentExt : BubbleSegment
    {
        protected override void Draw(ICanvas canvas)
        {
            base.Draw(canvas);

            if (Series is BubbleExt && Series.BindingContext is MarketCapViewModel viewModel)
            {

                float imageX = CenterX - (Radius / 2);
                float imageY = CenterY - (Radius / 2);

                float diameter = Radius * 2; // Since radius is half of the diameter
                canvas.DrawImage(viewModel.MarketCapData[Index].ImageIcon, CenterX - Radius, CenterY - Radius, diameter, diameter);
            }
        }
    }

}
