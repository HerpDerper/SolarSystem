using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Animation;

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
            List<Planet> PlanetList = new List<Planet>()
            {
                new Planet { Order = 1, PlanetName = "Меркурий", Mass = 3.33022 * Math.Pow(10,23), Square = 7.48 * Math.Pow(10,7), Volume = 6.083 * Math.Pow(10,10)},
                new Planet { Order = 2, PlanetName = "Венера", Mass =  4.8675 * Math.Pow(10,24), Square = 4.60 * Math.Pow(10,8), Volume = 9.38 * Math.Pow(10,11)},
                new Planet { Order = 3, PlanetName = "Земля", Mass = 5.9726 * Math.Pow(10,24), Square = 510072000, Volume = 1.08321 * Math.Pow(10,12)},
                new Planet { Order = 4, PlanetName = "Марс", Mass = 6.4171 * Math.Pow(10,23), Square = 1.4437 * Math.Pow(10,8), Volume = 1.6318 * Math.Pow(10,11)},
                new Planet { Order = 5, PlanetName = "Юпитер", Mass = 1.8986 * Math.Pow(10,27), Square = 6.21796 * Math.Pow(10,10), Volume = 1.43128 * Math.Pow(10,15)},
                new Planet { Order = 6, PlanetName = "Сатурн", Mass = 5.6846 * Math.Pow(10,26), Square = 4.272 * Math.Pow(10,10), Volume = 8.2713 * Math.Pow(10,14)}
            };
            PlanetGrid.ItemsSource = PlanetList;
        }

        /// <summary>
        /// Автоматически созданный метод для Button, устанавливает скорость движения планет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSpeedButton_Click(object sender, RoutedEventArgs e)
        {
            planet.ChangePlanetSpeed((int)SpeedSlider.Value * -1);
        }

        /// <summary>
        /// Автоматически созданный метод для ComboBox, изменяет выбранную планету
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Автоматически созданный метод для Button, останавливает или запускает движение планет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PauseResumedButton_Click(object sender, RoutedEventArgs e)
        {
            if (MercuryStoryboard.GetIsPaused(Mercury))
            {
                MercuryStoryboard.Resume(Mercury);
                VenusStoryboard.Resume(Venus);
                EarthStoryboard.Resume(Earth);
                MarsStoryboard.Resume(Mars);
                JupiterStoryboard.Resume(Jupiter);
                SaturnStoryboard.Resume(Saturn);
                PauseResumedButton.Content = "Пауза";
            }
            else
            {
                MercuryStoryboard.Pause(Mercury);
                VenusStoryboard.Pause(Venus);
                EarthStoryboard.Pause(Earth);
                MarsStoryboard.Pause(Mars);
                JupiterStoryboard.Pause(Jupiter);
                SaturnStoryboard.Pause(Saturn);
                PauseResumedButton.Content = "Пуск";
            }
        }
    }
}