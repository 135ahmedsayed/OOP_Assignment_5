namespace OOP_Assignment_05;
#region FirstProject
public class Point3D
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
}
#endregion