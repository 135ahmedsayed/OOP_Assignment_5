namespace OOP_Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FirstProject
            #region FirstProject(1,2)
            Point3D p = new Point3D(10, 10, 10);
            Console.WriteLine(p.ToString());
            #endregion

            #region FirstProject(3,4)

            Point3D p1, p2;
            p1 = Point3D.ReadPoint("point 1 : ");
            p2 = Point3D.ReadPoint("point 2 : ");
            if (p1 == p2) // using the overridden operator ==
                Console.WriteLine("Two are Equil");
            else
                Console.WriteLine("Two are't Equil");

            #endregion

            #region FirstProject(5,6)
            Point3D[] Points =
            {
                new Point3D(123, 2, 3),
                new Point3D(2, 5, 6),
                new Point3D(12, 8, 9),
                new Point3D(10, 11, 12),
                new Point3D(0, 80, 3),
                new Point3D(0, 8, 9),
            };
            // using the IComparable interface to sort the array
            Array.Sort(Points);
            Console.WriteLine("Points after sorting:");
            foreach (var point in Points)
            {
                Console.WriteLine(point);
            }
            // using the ICloneable interface to clone the object
            Point3D points = (Point3D)Points[0].Clone();
            Console.WriteLine("the smallest Point : " + points);
            #endregion
            #endregion

            #region SecondProject
            Console.WriteLine("Add = " + Math.Add());
            Console.WriteLine("Sub = " + Math.Subtract());
            Console.WriteLine("Mult = " + Math.Multiply());
            Console.WriteLine("Div = " + Math.Divide());
            #endregion
            Console.ReadKey();
        }
    }
}
