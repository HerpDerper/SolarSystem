using System;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SolarSystem
{
    public class Planet
    {
        private DoubleAnimationUsingPath AnimationX, AnimationY;
        private Ellipse PlanetShape;
        private Storyboard Storyboard;

        public int Order { get; set; }
        public string PlanetName { get; set; }
        public double Mass { get; set; }
        public double Square { get; set; }
        public double Volume { get; set; }

        /// <summary>
        /// Пустой конструктор для создания пустого экземпляра класса
        /// </summary>
        public Planet()
        { }

        /// <summary>
        /// Конструктор для заполнения данных о планете, анимации движения
        /// </summary>
        /// <param name="AnimationX">Анимация движения по оси X</param>
        /// <param name="AnimationY">Анимация движения по оси Y</param>
        /// <param name="PlanetShape">Планета (точнее форма паланеты)</param>
        /// <param name="Storyboard">Объявляет объект анимации со всеми ее свойствами и параметрами</param>
        public Planet(DoubleAnimationUsingPath AnimationX, DoubleAnimationUsingPath AnimationY, Ellipse PlanetShape, Storyboard Storyboard)
        {
            this.AnimationX = AnimationX;
            this.AnimationY = AnimationY;
            this.PlanetShape = PlanetShape;
            this.Storyboard = Storyboard;
        }

        /// <summary>
        /// Метод, изменяющий скорость движения планеты
        /// </summary>
        /// <param name="Speed">Скорость движения планеты</param>
        public void ChangePlanetSpeed(int Speed)
        {
            AnimationX.Duration = TimeSpan.FromSeconds(Speed); /// Скорость по оси X
            AnimationY.Duration = TimeSpan.FromSeconds(Speed); /// Скорость по оси Y
            Storyboard.Begin(PlanetShape);
        }
    }
}