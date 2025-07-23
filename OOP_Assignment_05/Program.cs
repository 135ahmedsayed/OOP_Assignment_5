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
            #endregion

            Console.ReadKey();
        }
    }
}
