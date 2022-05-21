using System;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SolarSystem
{
    public class Planet
    {
        private DoubleAnimationUsingPath AnimationX, AnimationY;
        private Ellipse PlanetName;
        private Storyboard Storyboard;
        public Planet(DoubleAnimationUsingPath AnimationX, DoubleAnimationUsingPath AnimationY, Ellipse PlanetName, Storyboard Storyboard)
        {
            this.AnimationX = AnimationX;
            this.AnimationY = AnimationY;
            this.PlanetName = PlanetName;
            this.Storyboard = Storyboard;
        }

        public void ChangePlanetSpeed(int Speed)
        {
            AnimationX.Duration = TimeSpan.FromSeconds(Speed);
            AnimationY.Duration = TimeSpan.FromSeconds(Speed);
            Storyboard.Begin(PlanetName);
        }
    }
}
