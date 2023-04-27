class TriangleSides
{
    static void Main(string[] args)
    {
        // prompting user to enter side1 of the triangle
        Console.Write("Enter The First Side: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        // prompting user to enter side2 of the triangle
        Console.Write("Enter The Second Side: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // prompting user to enter side3 of the triangle
        Console.Write("Enter The Third Side: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();    // just for spacing

        // check if the three sides form a valid triangle
        bool validTriangle = ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1));

        // display the result to the user
        if (validTriangle) 
        {
            Console.WriteLine("These Sides Could Repersent A Triangle");
        }

        else
        {
            Console.WriteLine("These Sides Could Not Represent A Triangle");
        }
    }
    // end of main method
}
// end of class
