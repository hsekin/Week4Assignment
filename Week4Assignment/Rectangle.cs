using System;
namespace Week4Assignment
{
	public class Rectangle
	{
		private float length;
		private float width;
		public Rectangle(float length, float width)
		{
			this.length = length;
			this.width = width;
		}
		public float CalculateArea()
		{
			return length * width;
		}
	}
}

