namespace Mindbox.Geometry
{
    public abstract class Shape
    {
        public abstract double Area { get; }
    }

    public class Circle : Shape
    {
        public double Radius { get; }
        public override double Area => Math.PI * (Radius * Radius);

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус круга не может быть отрицательным.");
            }
            Radius = radius;
        }
    }

    public class Triangle : Shape
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public bool IsRectangular
        {
            get
            {
                var sides = new double[] { FirstSide, SecondSide, ThirdSide };
                Array.Sort(sides);
                var bigSide = sides[2] * sides[2];
                var smallSide = sides[1] * sides[1] + sides[0] * sides[0];
                return bigSide == smallSide;
            }
        }
        public override double Area
        {
            get
            {
                // Формула Герона
                double semiperimeter = (FirstSide + SecondSide + ThirdSide) / 2; //Полупериметр
                return Math.Sqrt(semiperimeter * (semiperimeter - FirstSide) * (semiperimeter - SecondSide) * (semiperimeter - ThirdSide));
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
            {
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными.");
            }
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
    }
}