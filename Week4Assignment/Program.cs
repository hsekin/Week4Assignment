namespace Week4Assignment;

class Program 
{
    static void Main(string[] args)
    {
        // Excercise 1
        Car myCar = new Car("Supra", 2016, 99999999.9f);
        Console.WriteLine($"Brand: {myCar.GetBrand()}");
        Console.WriteLine($"Year: {myCar.Getyear()}");
        Console.WriteLine($"Price: {myCar.GetPrice()}");

        // Excercise 2
        BankAccount ba = new BankAccount("04334242452425");
        Console.WriteLine($"Account Balance : {ba.GetBalance()}");

        ba.Deposit(1000);
        Console.WriteLine($"You have deposited your Balance sucessfully your, New Balance is: Rs {ba.GetBalance()}");

        ba.Withdraw(500);
        Console.WriteLine($"You have withdraw your Balance sucessfully your,New Balance is: Rs {ba.GetBalance()}");
        Console.WriteLine($"Your Final Balance is : Rs {ba.GetBalance()}");

        // Excercise 3

        Rectangle rectangle = new Rectangle(4.5f, 3.2f);
        Console.WriteLine($"The Area of rectangle is {rectangle.CalculateArea()}");

        // Excercise 4
        Circle circle = new Circle(5);
        Console.WriteLine($"The Area of circle is {circle.CalculateArea()}");

        // Excercise 5

        Student student = new Student("Hsekin", 22, "Physics");

        // Excercise 6
        Stack<int> intStack = new Stack<int>();
        intStack.Push(10);
        intStack.Push(30);
        intStack.Push(20);
        
        int poppedItem = intStack.Pop();
        Console.WriteLine($"Popped item: {poppedItem}");
 
        int peekedItem = intStack.Peek();
        Console.WriteLine($"Peeked item: {peekedItem}");

        // Excercise 7
        Calender calender = new Calender();
        calender.PrintWeekdays();

        // Excercise 8
        Point2D pointA = new Point2D { X = 1.0f, Y = 2.0f };
        Point2D pointB = new Point2D { X = 4.0f, Y = 6.0f };
        float distance = DistanceCalculator.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Distance between Point A and Point B is : {distance}");
    }

}

