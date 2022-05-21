using System.Windows;

namespace SolarSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Planet planet;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeSpeedButton_Click(object sender, RoutedEventArgs e)
        {
            planet.ChangePlanetSpeed((int)SpeedSlider.Value * -1);
        }

        private void PlanetsBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            switch (PlanetsBox.SelectedIndex)
            {
                case 0:
                    planet = new Planet(Double1X, Double1Y, Mercury, MercuryStoryboard);
                    break;
                case 1:
                    planet = new Planet(Double2X, Double2Y, Venus, VenusStoryboard);
                    break;
                case 2:
                    planet = new Planet(Double3X, Double3Y, Earth, EarthStoryboard);
                    break;
                case 3:
                    planet = new Planet(Double4X, Double4Y, Mars, MarsStoryboard);
                    break;
                case 4:
                    planet = new Planet(Double5X, Double5Y, Jupiter, JupiterStoryboard);
                    break;
                case 5:
                    planet = new Planet(Double6X, Double6Y, Saturn, SaturnStoryboard);
                    break;
            }
        }
    }
}