using System;
namespace Week4Assignment
{
	public class Student
	{
		private string name;
		private int age;
		private string major;
		public Student(string name, int age, string major)
		{
			this.name = name;
			this.age = age;
			this.major = major;
		}
		public void Introduce()
		{
			Console.WriteLine($"Hello everyone it's me {name}, and i m {age} years Old with the major in {major}");
		}
	}
}

