using System;
namespace Week4Assignment
{
	public class Car 
	{
		private String brand;
		private int year;
		private float price;

        public Car(String brand, int year, float price)
		{
			this.brand = brand;
			this.year = year;
			this.price = price;
			}

		public string GetBrand()
		{
			return brand;
		}
		public int Getyear()
		{
			return year;
		}
		public float GetPrice()
		{
			return price;
		}
	}

	
}


