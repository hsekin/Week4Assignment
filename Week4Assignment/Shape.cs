using System;
namespace Week4Assignment
{
	public class Shape
	{
		public virtual float CalculateArea()
		{
			return 0;
		}
	}

	public class Circle : Shape
	{
		public float radius = 5;
		public Circle(float radius)
		{
			this.radius = radius;
		}
        public override float CalculateArea()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }
    }
}

