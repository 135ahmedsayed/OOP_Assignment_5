namespace OOP_Assignment_05;
#region FirstProject
public class Point3D : IComparable<Point3D> , ICloneable
{
    #region FirstProject(1,2)
    public int p1 { get; set; }
    public int p2 { get; set; }
    public int p3 { get; set; }
    private Point3D() : this(0, 0, 0) { } // chaining in constructors
    public Point3D(int x, int y)// chaining in constructors
    {
        this.p1 = x;
        this.p2 = y;
    }
    public Point3D(int p1, int p2, int p3)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
    }
    public override string ToString()
    {
        return $"Point Coordinates: ({p1}, {p2}, {p3})";
    }
    #endregion

    #region FirstProject(3,4)
    // Create ReadPoint From User
    public static Point3D ReadPoint(string str)
    {
        Console.WriteLine($"Please Enter {str}");
        int p1 = int.Parse(Console.ReadLine()!);
        int p2 = int.Parse(Console.ReadLine()!);
        int p3 = int.Parse(Console.ReadLine()!);
        return new Point3D(p1, p2, p3);
    }
    // Override Operator ==
    public static bool operator ==(Point3D p1, Point3D p2)
    {
        if (p1.p1 == p2.p1 && p1.p2 == p2.p2 && p1.p3 == p2.p3)
        {
            return true;
        }
        return false; // or throw an exception
    }
    public static bool operator !=(Point3D p1, Point3D p2)
    {
        if (p1.p1 == p2.p1 && p1.p2 == p2.p2 && p1.p3 == p2.p3)
        {
            return false;
        }
        return true; // or throw an exception
    }
    #endregion

    #region FirstProject(5,6)
    public int CompareTo(Point3D? other)
    {
        if (other is null)
            return 1; // null is considered less than any instance
        if (this.p1.CompareTo(other.p1) == 1)
            return 1; // this instance is greater than other
        if (this.p1.CompareTo(other.p1) == 0)
            return this.p2.CompareTo(other.p2); // if p1 is equal, compare p2
        return -1;
    }

    public object Clone()
    {
        return new Point3D
                (
                    this.p1,
                    this.p2,
                    this.p3
                );
    }
    #endregion
}
#endregion